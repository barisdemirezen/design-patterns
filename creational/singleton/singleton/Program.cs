using singleton;

// We can't create an object with New keyword like below since it's constructor is private
// SqlServer sqlServer = new SqlServer(); 

// Creating instance by static method
SqlServer sqlServer1 = SqlServer.CreateObject();

// Trying to create another instance by same method
SqlServer sqlServer2 = SqlServer.CreateObject();

bool isObjectsEqual = sqlServer1 == sqlServer2;
bool isHashCodesEqual = sqlServer1.GetHashCode() == sqlServer2.GetHashCode();

Console.WriteLine($"Test - 1 -> Is objects are equal: {isObjectsEqual}");
Console.WriteLine($"Test - 2 -> Is hash codes are equal: {isHashCodesEqual}");