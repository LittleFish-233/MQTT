namespace MQTT.Model
{
    public class SubscribeModel
    {
        public string Topic { get; set; }

        public List<SubscribeMessageModel> Messages = new List<SubscribeMessageModel>();
    }

    public class SubscribeMessageModel
    {
        public string Message { get; set; }

        public DateTime Time { get; set; }
    }
}
