Imports System.Threading.Tasks
Imports AdvancedHMIDrivers

Public Class MainForm

    Private mqtt As New MqttClientAHMI

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub Mqtt_MessageReceived(topic As String, payload As String)
        Me.Invoke(Async Sub()
                      Dim value As Integer
                      If Integer.TryParse(payload, value) Then
                          DF1COM.Write("B3:2/7", value)
                          Status.Text = "MQTT Value = " & value

                          Await Task.Delay(200)

                          DF1COM.Write("B3:2/7", 0)

                      Else
                          Status.Text = "Invalid MQTT payload: " & payload
                      End If
                  End Sub)
    End Sub


    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler mqtt.MessageReceived, AddressOf Mqtt_MessageReceived

        Await mqtt.Connect("127.0.0.1", 1883)
        Await mqtt.Subscribe("energize")

        Status.Text = "MQTT Connected"
    End Sub




End Class
