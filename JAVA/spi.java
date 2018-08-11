import java.util.*;
import java.io.*;

     class Students 
	 {
        long eroll,sem;
        String name;
		String Grades[]=new String[6];
		int point=0;
		int count=0;
		Scanner sc=new Scanner(System.in);
		public void input()
		{
			System.out.println("Enter Your Roll No.= ");
			eroll=Long.parseLong(sc.nextLine());
			System.out.println("Enter your Name= ");
			name=sc.nextLine();
			System.out.println("Enter Your Semester= ");
			sem=Integer.parseInt(sc.nextLine());
			System.out.println("Enter Your Grades:{AA,AB,BB,BC,CC,CD,DD}");
			
			for(int i=0;i<6;i++)
			{
				Grades[i]=sc.nextLine();
				switch(Grades[i])
				{
					case "AA": point=point+10;break;
					case "AB": point=point+9;break;
					case "BB": point=point+8;break;
					case "BC": point=point+7;break;
					case "CC": point=point+6;break;
					case "CD": point=point+5;break;
					case "DD": point=point+4;break;
					case "FF": point=point+0;count ++;break;
					default:System.out.println("Invalid Grade Input");break;
				}
			}
		}
		
		public void show()
		{
			
			 System.out.println("Name= "+name+"\tRoll No.= "+eroll+"\tSemester= "+sem+"\n Grades= ");
		
			for(int i=0;i<6;i++)
			{
				System.out.println(Grades[i]);
			}
			System.out.println();
			for(int i=0;i<50;i++)
			{
				System.out.print("==");
			}
			System.out.println();
			System.out.println(" SPI= "+((point)*6)/36);
			if(count>0)
		    {
			
			System.out.println("You are Failed in "+count+" Subject");
			
			
			}
		}
		
	 }
	 
	 public class Spi
{
		public static void main(String args[])throws IOException
		{
			Students s=new Students();
			s.input();
			s.show();
		}	
        		
 }
