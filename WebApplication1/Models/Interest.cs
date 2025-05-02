namespace basicpractice.Models

{
    public class Interest
    {
        private float p;
        private float r;
        private float t;

        public float T { get => t; set => t = value; }
        public float R { get => r; set => r = value; }
        public float P { get => p; set => p = value; }
    }
}
