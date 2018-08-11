class Fibonacci
{
	public static void main(String[] args)
	{
		int a=0,b=1,c;
		int n=Integer.parseInt(args[0]);
if(n==0)
			System.out.print(a+" ");
		if(n>0)
		{
			System.out.print(a+" ");
			System.out.print(b+" ");
		}
		for(int i=2;i<=n;i++)
		{
			c=a+b;
			System.out.print(c+" ");
			a=b;
			b=c;
		}
	}
}
