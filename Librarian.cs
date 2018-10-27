using System; 
using System.Collections; 
using System.Collections.Generic; 

namespace Library {
class Librarian:User {

private double salary; 

private DateTime startDate; 

private DateTime birthday; 
Address address; 
	
    public DateTime getBirthday()
	{
		return this.birthday;
	}

	public void setBirthday(DateTime birthday)
	{
		this.birthday = birthday;
	}

	public DateTime getStartdate () {
		return this.startDate; 
	}

	public void setStartdate (DateTime startDate) {
		this.startDate = startDate; 
	}


    public double getSalary() {
        return this.salary; 
    }

    public void setSalary (double salary) {
        this.salary = salary; 
    }

    public void setAddress (String street, String town, int postalCode) {
        this.address.setStreet(street);
        this.address.setTown(town);
        this.address.setPostalCode(postalCode);
    }


    }
}