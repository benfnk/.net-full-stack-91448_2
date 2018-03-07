    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Reflection;

    namespace DnamicCodeTutorial
    {
        class Program
        {

            static void Main(string[] args)
            {
                // this strig has code 
                string lcCode = @"
                    namespace MyNamespace {
                    public class MyClass {
                    public object DynamicCode(params object[] Parameters) {
                    int a =3;
                    System.Console.WriteLine(a);
                    return a;
                    } } }";

                ICodeCompiler loCompiler = new CSharpCodeProvider().CreateCompiler();
                CompilerParameters loParameters = new CompilerParameters();

                // Start by adding any referenced assemblies
                loParameters.ReferencedAssemblies.Add("System.dll");

                // Load the resulting assembly into memory
                loParameters.GenerateInMemory = false;

                // Now compile the whole thing
                CompilerResults loCompiled =
                  loCompiler.CompileAssemblyFromSource(loParameters, lcCode);

                if (loCompiled.Errors.HasErrors)
                {
                    string lcErrorMsg = "";
                    lcErrorMsg = loCompiled.Errors.Count.ToString() +
                                 " Errors:";
                    for (int x = 0; x < loCompiled.Errors.Count; x++)
                        lcErrorMsg = lcErrorMsg + " Line: " +
                                     loCompiled.Errors[x].Line.ToString() +
                                      " - " + loCompiled.Errors[x].ErrorText;
                    Console.WriteLine(lcErrorMsg + " " + lcCode);

                    return;
                }

                Assembly loAssembly = loCompiled.CompiledAssembly;

                // Retrieve an obj ref - generic type only
                object loObject = loAssembly.CreateInstance("MyNamespace.MyClass");

                if (loObject == null)
                {
                    Console.WriteLine("Couldn't load class.");
                    return;
                }

                object[] loCodeParms = new object[1];

                loCodeParms[0] = "Dynamic code Technologies";

                try
                {
                    object loResult = loObject.GetType().InvokeMember(
                                     "DynamicCode", BindingFlags.InvokeMethod,
                                     null, loObject, loCodeParms);

                    Console.WriteLine("Method Call Result: " + loResult);
                }

                catch (Exception loError)
                {
                    Console.WriteLine("Error: " + loError.Message);
                }
            }
        }
    }

