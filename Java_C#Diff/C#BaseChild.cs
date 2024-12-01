using System;

class Base
{
    public virtual void print()
    {
        Console.WriteLine("Base Class Method");
    }
}

class Child : Base
{
    public override void print()
    {
        Console.WriteLine("Child Class Method");
    }
}


class HelloWorld {
  static void Main() {
    Base b = new Child();
    b.print();
  }
}
