class ExceptionHandling
{
	public static void main(String args[])
	{
		int len,i;
		int sum=0,t,num;
		len=args.length;
		for(i=0;i<len;i++)
		{	
			num=Integer.parseInt(args[i]);
			try	
			{	
				if(num<0)
					throw new Exception("Number "+num+" is Negative");
				else if(num>1000 && num<2000)
					throw new Exception("Number "+num+" is between 1000 and 2000");
				else if(num>7000)
					throw new Exception("Number "+num+" is greater than 7000");
				else
				{
					int number=num,digit=0,sumOfDigits=0;
					while (number != 0)
 					{
  						digit = number % 10;
  						sumOfDigits = sumOfDigits + digit;
  						number = number / 10;
 					}
					if(sumOfDigits%10==0)
						throw new Exception("Number "+num+" is Evenly Divisible by 10");
				}	
				
			}
			catch(Exception e)
			{
				System.out.println("Exception : "+e);
				continue;
			}
			sum=sum+num;
		}
		System.out.println("Sum of all the number is : "+sum);
	}
}
