namespace MQTT.Model
{
    public class MessageModel
    {
        public bool IsDelete { get; set; }

        public string Topic { get; set; }

        public string Message { get; set; }
    }
}
