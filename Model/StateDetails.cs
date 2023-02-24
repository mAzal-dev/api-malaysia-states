namespace Malaysia_states.Model
{
    public class StateDetails
    {
        public string administrative_division {get;set;}
        public string state { get;set;}
        public string capital { get; set; }
        public string royal_capital { get; set; }
        public int population { get; set; }
        public int total_area { get; set; }
        public string license_plate_prefix { get; set; }
        public string phone_area_code { get; set; }
        public string abbreviation { get; set; }
        public string ISO { get; set; }
        public string FIPS { get; set; }
        public double HDI { get; set; }
        public string region { get; set; }
        public string head_of_state { get; set; }
        public string head_of_government { get; set; }
    }
    public class rootStateDetails
    {
        public List<StateDetails> data { get; set; }
    }
}
