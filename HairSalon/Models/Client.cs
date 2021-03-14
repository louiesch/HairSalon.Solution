namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }

// experimenting with ways to make stylist required when creating client. So far no success.
    // [Required(ErrorMessage = "Stylist is required.")]
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}