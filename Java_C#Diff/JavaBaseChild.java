class Base
{
    public void print()
    {
        System.out.println("Base Print Method");
    }
}

class Child extends Base
{
    public void print()
    {
        System.out.println("Child Print Method");
    }
}
public class JavaBaseChild
{
	public static void main(String[] args) {
		Base b = new Child();
		b.print();
	}
}
