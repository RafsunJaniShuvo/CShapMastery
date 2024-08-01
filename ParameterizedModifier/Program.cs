
using ParameterizedModifier;

Example example = new Example();
example.sum(1,2,3); // using params in example class
int p = 10;
example.xxx(ref p); // reference type
Console.WriteLine(p);
example.yyy(20);
example.zzz(out p); // have to pass with out keyword
