# VIBRATION MONITORING AND ALARM SYSTEM

Author: Vasilis Dimitriou

Type: Industrial Implementation Project
Scope: Integration of STM32 embedded controller with Allen-Bradley PLC system



# PROJECT OVERVIEW

This project focuses on the implementation and integration of an embedded
vibration monitoring system based on an STM32 microcontroller and an
industrial Allen-Bradley PLC platform.

The system combines embedded data acquisition, signal processing, MQTT
communication, SCADA visualization, and industrial alarm logic into a unified
condition monitoring architecture.

The goal is to demonstrate a complete industrial pipeline from sensor
acquisition → signal processing → frequency analysis → data streaming → PLC
alarm execution.

Main technologies integrated:

STM32 Embedded Controller  
ADXL335 Vibration Sensor  
USB CDC Streaming  
C++ High-Speed Data Acquisition  
FFT Signal Processing  
MQTT Communication Layer  
Telegraf MQTT → InfluxDB Bridge  
InfluxDB Time-Series Storage  
AdvancedHMI SCADA Interface  
Allen-Bradley PLC Alarm System  


# PROJECT STRUCTURE

ROOT PROJECT
│
├── STM32_Project_v9/
│   ├── Core/
│   ├── Drivers/
│   ├── USB_Device/
│   ├── ADC + DMA configuration
│   ├── main.c (sensor acquisition loop)
│   ├── usbd_cdc_if.c (USB CDC streaming)
│   └── ADXL335 analog sampling @ ~15 kHz
│
├── sourceCode/
│   ├── main.cpp (C++ data collector)
│   ├── mqtt/
│   │   ├── publisher.cpp
│   │   └── mqtt_client.hpp
│   ├── influxdbsql/
│   │   ├── write_api.cpp
│   │   └── bucket_setup.json
│   ├── telegraf/
│   │   └── telegraf.conf (MQTT → InfluxDB pipeline)
│   ├── conversion/
│   │   ├── adc_to_g.cpp
│   │   └── filtering.cpp (RMS, FFT, smoothing)
│   ├── config.yaml
│   └── CMakeLists.txt
│
├── HMI_PLC_ALARM/
│   ├── AdvancedHMI/
│   │   ├── MainForm.vb (MQTT → PLC logic)
│   │   ├── MqttClientAHMI.vb
│   │   ├── DF1COM driver
│   │   └── UI elements (labels, indicators)
│   ├── PLC/
│   │   ├── pump_vibration_alarm.RSS (RSLogix 500)
│   │   ├── Alarm Trigger Logic (B3:4/14 pulse)
│   │   ├── Alarm Reset / Silence bits
│   │   └── Critical Alarm Ladder
│   └── MQTT/
│       ├── mosquitto_pub test commands
│       └── energize topic mapping
│
├── backup/
│   ├── old STM32 versions
│   ├── old C++ collectors
│   ├── old HMI builds
│   ├── archived ladder logic
│   └── additional PLC course projects (10 total)
│
└── README.md




# SYSTEM DATA FLOW


ADXL335 Sensor
│
V
STM32 ADC + DMA
│
V
USB CDC Streaming
│
V
C++ Collector
│
V
FFT Processing Layer
│
+-----------------------+
│                       │
V                       V
MQTT Waveform        MQTT Alarm Signal
│                       │
V                       V
Telegraf             AdvancedHMI SCADA
│                       │
V                       V
InfluxDB             Allen-Bradley PLC
│
V
Industrial Alarm Logic


#CONTROLLER (STM32) & SIGNAL PROCESSING DETAILS

The STM32 controller continuously acquires vibration data from the ADXL335
sensor using high-speed ADC + DMA sampling.

Sampling characteristics:

Sampling rate: ~15 kHz  
Acquisition window: 60 seconds  
Total samples per axis: ~900,000 samples per minute  
Axes: X, Y, Z  

This produces a high-resolution time-domain dataset suitable for industrial
condition monitoring and fault detection.



# FREQUENCY DOMAIN TRANSFORMATION (FFT)


After acquisition, the system performs FFT transformation on the dataset.

Key result:

Frequency analysis range: up to ~7500 Hz

This allows detection of:

- Bearing faults  
- Mechanical resonance  
- High-frequency vibration anomalies  
- Structural vibration patterns  


# DATA REDUCTION STRATEGY (IMPORTANT DESIGN DECISION)


Although the system generates a very high-volume dataset, not all data is
transmitted to external systems.

Reason: MQTT + InfluxDB throughput limitations and real-time constraints.

Problem:
- 900,000 samples per minute is too large for continuous MQTT streaming  
- Full FFT resolution creates excessive network and storage load  

Solution: Data downsampling and controlled publishing

Final effective output rate:

~500 Hz equivalent data stream sent to InfluxDB pipeline

This ensures:

- Stable MQTT communication  
- Reduced network bandwidth usage  
- Faster Telegraf ingestion  
- Efficient InfluxDB storage  
- Real-time SCADA responsiveness  

Trade-off: reduced resolution in exchange for system stability and real-time
performance.


# MQTT ARCHITECTURE


Waveform Topic:
vibration/sensor1/waveform/<date>

Frequency Topic:
vibration/sensor1/frequencies/<date>

Alarm Topic:
energize

Payload:
0 → Normal operation  
1 → Vibration alarm triggered  


# C++ DATA PROCESSING PIPELINE

- Read USB CDC stream from STM32  
- Store raw ADC values  
- Convert to physical units  
- Apply FFT processing  
- Generate waveform JSON payloads  
- Generate frequency spectrum JSON payloads  
- Publish via MQTT  
- Publish alarm bit based on threshold detection  


# INFLUXDB STORAGE SYSTEM

InfluxDB is used as a time-series database for:

Waveform bucket:
vibration_waveform  
→ stores time-domain vibration signals  

Frequency bucket:
vibration_frequency  
→ stores FFT results and spectral data  


# TELEGRAF PIPELINE


Telegraf acts as a bridge between MQTT and InfluxDB:

MQTT Broker → Telegraf → InfluxDB

Subscribed topics:

- vibration waveform data  
- frequency spectrum data  


# ADVANCEDHMI + PLC SYSTEM

AdvancedHMI receives MQTT alarm messages from topic:

energize

Behavior:

- Converts MQTT message into PLC pulse signal  
- Writes to DF1 register (B3:2/7)  
- Generates 200ms pulse trigger  

PLC behavior:

- Latches alarm condition  
- Executes reset/silence logic  
- Drives industrial alarm outputs  

<img width="771" height="421" alt="Untitled" src="https://github.com/user-attachments/assets/41dd26f0-f128-463f-a570-f120f11087c9" />




# REPOSITORY STRUCTURE (IMPORTANT NOTE)


This project is organized into two main repositories:

MAIN REPOSITORY
Contains the full vibration monitoring system including:

- STM32 firmware project  
- C++ data acquisition and processing pipeline  
- MQTT communication layer  
- FFT analysis system  
- InfluxDB + Telegraf integration  
- AdvancedHMI SCADA interface  
- PLC alarm integration project  
- Complete end-to-end industrial monitoring system  

SECONDARY REPOSITORY
Contains approximately 10 separate PLC projects developed during the PLC course:

- Basic ladder logic exercises  
- Timer and counter implementations  
- Motor control logic  
- Alarm handling experiments  
- Sequencing systems  
- Industrial simulation tasks  
- Training examples for RSLogix 500  
- Educational PLC structures and patterns  


# STARTUP SEQUENCE

1. Start MQTT Broker (Mosquitto)  
2. Start InfluxDB (influxd.exe)  
3. Start Telegraf service  
4. Launch AdvancedHMI SCADA  
5. Run C++ data collector (main.exe)  
6. Observe PLC alarm response and database ingestion  


# KEY SUMMARY

This system demonstrates a full industrial condition monitoring pipeline with:

- High-speed embedded acquisition (900k samples/minute)  
- FFT-based vibration analysis up to 7500 Hz  
- MQTT real-time communication system  
- Controlled data reduction (~500 Hz output)  
- SCADA visualization through AdvancedHMI  
- PLC-based industrial alarm handling  
- Dual-repository architecture (system + PLC training projects)  
