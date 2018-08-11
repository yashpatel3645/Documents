class A
{
 int a;
 void getdata(int f)
{
 f=a;
}
 void display()
{
 System.out.println("Value of a is = "+a);
}
}
class B extends A
{
 int b;
 void get(int g)
{
 g=b;
}
 void dis()
{
 System.out.display("Value of b is ="+b);
}
}
class multilevel
{
 public static void main(String args[])
{
 B ob=new B();
 ob.getdata(21);
 ob.display();
 ob.get(32);
 ob.dis();
}
}