namespace DestructionAPI
{
    public class DestructionAPI
    {
        public string Name { get; } = "DestructionAPI";

        public string Version { get; } = "0.1.0";


        public DestructionAPI()
        {
        }


        public string GetInfo()
        {
            return $"{Name} v{Version}";
        }
    }
}
