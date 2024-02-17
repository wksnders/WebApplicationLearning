namespace BlazorApp2.Models
{
    public struct Testimonial {
        public string Quote;
        public string PositionAndCompany;
        public string Name;
        public bool OnLinkedIn;
    }
    public static class Testimonials
    {

        private static readonly List<Testimonial> TestimonialList = new List<Testimonial>();

        public static List<Testimonial> GetTestimonialList()
        {
            if (TestimonialList.Count == 0)
            {//add test data
                TestimonialList.Add(new Testimonial
                {
                    Quote = "Wyatt is a sharp developer with a positive attitude and a great aptitude learn and accept feedback. During the time that I worked with him, his positive attitude when taking on tasks and incorporating direction changes stood out to me. Wyatt was always quick to jump in with helpful and relevant design feedback, and demonstrated an impressive mental library of mechanics of other games to draw on.\r\n\r\nWyatt's ego-free nature makes him very easy to work with. He's on his way to becoming a great engineer.",
                    PositionAndCompany = "CCO, Solar Forge Games",
                    Name = "Jake Muehle",
                    OnLinkedIn = true
                });
                TestimonialList.Add(new Testimonial
                {
                    Quote = "Street Fighter II",
                    PositionAndCompany = "Director, Octothorpe",
                    Name = "Matt Anderson",
                    OnLinkedIn = true
                });
                
            }
            return TestimonialList;
        }
    }
}
