class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} at {_time}\n{_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDetails()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
}