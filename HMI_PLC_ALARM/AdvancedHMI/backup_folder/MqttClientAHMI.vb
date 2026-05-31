Imports System.Text
Imports System.Threading.Tasks
Imports MQTTnet
Imports MQTTnet.Client
Imports MQTTnet.Client.Options

Public Class MqttClientAHMI
    Private client As IMqttClient
    Private options As IMqttClientOptions

    Public Event MessageReceived(topic As String, payload As String)

    Public Async Function Connect(broker As String, port As Integer) As Task
        Dim factory = New MqttFactory()
        client = factory.CreateMqttClient()

        client.UseConnectedHandler(
            Sub(e)
                Console.WriteLine("MQTT Connected")
            End Sub)

        client.UseApplicationMessageReceivedHandler(
            Sub(e)
                Dim msg As String = Encoding.UTF8.GetString(e.ApplicationMessage.Payload)
                RaiseEvent MessageReceived(e.ApplicationMessage.Topic, msg)
            End Sub)

        options = New MqttClientOptionsBuilder() _
            .WithClientId("AHMI_" & Guid.NewGuid().ToString()) _
            .WithTcpServer(broker, port) _
            .Build()

        Await client.ConnectAsync(options)
    End Function

    Public Async Function Publish(topic As String, payload As String) As Task
        If client Is Nothing OrElse Not client.IsConnected Then Exit Function

        Dim message = New MqttApplicationMessageBuilder() _
            .WithTopic(topic) _
            .WithPayload(payload) _
            .Build()

        Await client.PublishAsync(message)
    End Function

    Public Async Function Subscribe(topic As String) As Task
        If client Is Nothing OrElse Not client.IsConnected Then Exit Function

        Await client.SubscribeAsync(topic)
    End Function
End Class
