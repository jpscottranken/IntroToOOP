public class Person {
	//	Instance variables
	private String  firstName;
	private String  lastName;
	private String  eyeColor;
	private String  hairColor;
	private int     height;
	private int     weight;
	private String  gender;
	private boolean isMarried;

	//	Default constructor
	public Person() {}

	//	Getters
	public String getFirstName()
	{
		return firstName;
	}

	public String getLastName()
	{
		return lastName;
	}

	public String getEyeColor()
	{
		return eyeColor;
	}

	public String getHairColor()
	{
		return hairColor;
	}

	public int getHeight()
	{
		return height;
	}

	public int getWeight()
	{
		return weight;
	}

	public String getGender()
	{
		return gender;
	}

	public Boolean getIsMarried()
	{
		return isMarried;
	}

	//	Setters
	public void getFirstName(String firstName)
	{
		this.firstName = firstName;
	}

	public void getLastName(String lastName)
	{
		this.lastName = lastName;
	}

	public void getEyeColor(String eyeColor)
	{
		this.eyeColor = eyeColor;
	}

	public void getHairColor(String hairColor)
	{
		this.hairColor = hairColor;
	}

	public void getHeight(int height)
	{
		this.height = height;
	}

	public void getWeight(int weight)
	{
		this.weight = weight;
	}

	public void getGender(String gender)
	{
		this.gender = gender;
	}

	public Boolean getIsMarried(Boolean isMarried)
	{
		this.isMarried = isMarried;
	}

	public void Eat(String food)
	{
		System.out.println(GetFirstName() + " " + GetLastName() +
                      " is eating " + food);)
	}

	public void Drink(String liquid)
	{
		System.out.println(GetFirstName() + " " + GetLastName() +
                      " is drinking " + liquid);)
	}

	public void Sleep(int numHours)
	{
		System.out.println(GetFirstName() + " " + GetLastName() +
                      " is sleeping for " + numHours + " hours");
	}
}