import java.io.*;
import java.util.*;
class StudentManager
{
 public static void main(String args[])
{
 List <Student> studList=new ArrayList<Student>();
 String name;
 int roll;
 double marks;
 char ans='y';
 try
{
 FileOutputStream fs = new FileOutputStream("object.txt");
 BufferedOutputStream bs = new BufferedOutputStream(fs);
 ObjectOutputStream os = new ObjectOutputStream(bs);
 Scanner input = new Scanner(System.in);
 do
{
 System.out.println("\n Enter Name of the Student: ");
 name=input.next();
 System.out.println("\n Enter roll number of the Student: ");
 roll=input.nextInt();
 System.out.println("\n Enter marks of the Students: ");
 marks=input.nextDouble();
 Student s1 = new Student(name,roll,marks);
 os.writeObject(s1);
 os.flush();
 System.out.println("\n Do you want to continue?(y/n)");
 ans=input.next().charAt(0);
}while(ans=='y'||ans=='Y');
 os.close();
}
catch(Exception e)
{
 e.printStackTrace();
}
try
{
 FileOutputStream fis = new FileOutputStream("object.txt");
 BufferedOutputStream bis = new BufferedOutputStream(fis);
 ObjectOutputStream ois = new ObjectOutputStream(bis);
 while(true)
{
 Object obj = osi.readObject();
 if(obj instanceof Student)
 studList.add((Student)obj);
else 
 break;
}
 osi.close();
}
catch(Exception e){}
Iterator <Student> items=studList.iterator();
while(items.hasNext())
{
 Student S1=items.next();
 System.out.println(S1.name+" ");
 System.out.println(S1.rollno+" ");
 System.out.println(S1.submarks+" ");
 System.out.println();
}
}
}