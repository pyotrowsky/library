using System; 

namespace Library {
    abstract class Address {
    
    private String street;
    private String town;
    private int postalCode;

	public String getStreet()
	{
		return this.street;
	}

	public void setStreet (String street)
	{
		this.street = street;
	}

    public String getTown()
	{
		return this.town;
	}

	public void setTown (String town)
	{
		this.town = town;
	}

    public int getPostalCode()
	{
		return this.postalCode;
	}

	public void setPostalCode (int postalCode)
	{
		this.postalCode = postalCode;
	}

  
    }
}