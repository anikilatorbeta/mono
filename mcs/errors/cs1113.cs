// CS1113: Extension method `Extension.Foo(this S)' of value type `S' cannot be used to create delegates
// Line: 12


delegate void D ();

public class C
{
	static void Main ()
	{
		S s = new S ();
		D d = s.Foo;
	}
}

public struct S
{
}

public static class Extension
{
	public static void Foo (this S s) { }
}
