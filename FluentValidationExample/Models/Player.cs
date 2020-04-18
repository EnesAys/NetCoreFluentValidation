namespace FluentValidationExample.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public bool IsCanPlay { get; set; }
        public bool IsOutOfStaff => IsCanPlay ? false : true;
    }
}
