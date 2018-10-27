using System; 

namespace Library {
    abstract class User {
    protected String firstName {get; set;}
    protected String lastName; 
    protected int refNo;

    public User(){ 
		
	}

    //     public String getFirstname()
	// {
	// 	return this.firstName.Trim();
	// }

	// public void setFirstname(String firstName)
	// {
	// 	this.firstName = firstName.Trim();
	// }

	public String getLastname()
	{
		return this.lastName.Trim();
	}

	public void setLastname(String lastName)
	{
		this.lastName = lastName.Trim();
	}

	public int getRefno()
	{
		return this.refNo;
	}

	public void setRefno(int refNo)
	{
		this.refNo = refNo;
	}


    public String getFullName() {
        return this.firstName.Trim() + this.lastName.Trim();
    }


    


    }

}
