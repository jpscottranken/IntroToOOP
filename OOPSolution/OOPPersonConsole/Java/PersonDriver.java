public class Main {
	public static void main(String[] args) {
		Person person1 = new Person();

		     //  Print out all default values  for person1
            //  By Calling the Getter Methods for person1
            //System.out.println("Print out all default values for person1 using getters");
            //System.out.println("The first name of person1 is: "      + person1.getFirstName());
            //System.out.println("The last  name of person1 is: "      + person1.getLastName());
            //System.out.println("The eye color  of person1 is: "      + person1.getEyeColor());
            //System.out.println("The hair color of person1 is: "      + person1.getHairColor());
            //System.out.println("The height of person1 is: "          + person1.getHeight().ToString());
            //System.out.println("The weight of person1 is: "          + person1.getWeight().ToString());
            //System.out.println("The gender of person1 is: "          + person1.getGender());
            //System.out.println("The marital status of person1 is: "  + person1.getIsMarried());

            //  Call the Setter for each instance variable for person1
            person1.setFirstName("Jeff");
            person1.setLastName("Scott");
            person1.setEyeColor("Blue");
            person1.setHairColor("Brown");
            person1.setHeight(72);
            person1.setWeight(250);
            person1.setGender("Male");
            person1.setIsMarried(true);

            //  Call the Getter Methods for person1
            System.out.println("Print out all values for person1 using getters after using setters");
            System.out.println("The first name of person1 is: " + person1.GetFirstName());
            System.out.println("The last  name of person1 is: " + person1.GetLastName());
            System.out.println("The eye color  of person1 is: " + person1.GetEyeColor());
            System.out.println("The hair color of person1 is: " + person1.GetHairColor());
            System.out.println("The height of person1 is: " + person1.GetHeight().ToString());
            System.out.println("The weight of person1 is: " + person1.GetWeight().ToString());
            System.out.println("The gender of person1 is: " + person1.GetGender());
            System.out.println("The marital status of person1 is: " + person1.GetIsMarried());

            //  Call non-getter/non-setter methods of the Person class
            person1.Eat("Cake");
            person1.Drink("Milk");
            person1.Sleep(8);
	}
}