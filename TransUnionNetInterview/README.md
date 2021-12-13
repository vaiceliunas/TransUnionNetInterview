Demo task for transUnion interview.

You may modify the amount of nominals ATM machine keeps at Models -> Dal -> ImaginaryStorage.cs

There is brute force method implemented where possible nominals are ordered form Max to min value, and each combination of possible sums are tried out. 
Whenever one of the nominal combinations is found - flag "_resultFound" is marked and recursive calculation is finished.

In case no combination was found, exception is thrown after all the calculations in Program.cs

Results are printed in console.

Altough this method is pretty slow (that's why I named it brute force), you may implement another way of calculating result by just creating new class, implementing ICalculator
and passing your newly created class object to ATM machine creation.
