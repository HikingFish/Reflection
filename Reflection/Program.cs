using Reflection;

var annonymousField = typeof(SecretAgent).GetField("_codename", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

var SecretAgentInstance = new SecretAgent();

var currentValue = annonymousField.GetValue(SecretAgentInstance);
Console.WriteLine(currentValue);

annonymousField.SetValue(SecretAgentInstance, "008");
var newValue = annonymousField.GetValue(SecretAgentInstance);
Console.WriteLine(newValue);