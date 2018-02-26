
using CIS.CodeDom.Csharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.DNA.Soul.Code
{
    class Program
    {
        static void Main(string[] args)
        {

            var _unit1 = new CsCompileUnit(); var _attribute2 = new CsAttributeCollection();

            ((ICsUnit)_unit1).AttributesUnit = _attribute2; var _alias2 = new CsExternAliasCollection();

            ((ICsUnit)_unit1).ExternAliases = _alias2; var _using2 = new CsUsingCollection(); var _namespace2 = new CsNamespace();
            ((ICsNamespace)_namespace2).NamespaceName = new CsIdentifier("System");
            var _attribute4 = new CsAttributeCollection();

            ((ICsNamespace)_namespace2).Attributes = _attribute4;
            var _alias4 = new CsExternAliasCollection();

            ((ICsNamespace)_namespace2).Aliases = _alias4;
            var _var5 = new CsNamespaceMemberCollection();

            ((ICsNamespace)_namespace2).NamespaceMembers = _var5;
            var _using4 = new CsUsingCollection();
            ((ICsNamespace)_namespace2).Usings = _using4;

            var _namespace3 = new CsNamespaceReference(_namespace2); var _using9 = new CsUsing(_namespace3);
            _using2.Usings.Add(_using9);
            ((ICsUnit)_unit1).Usings = _using2; var _namespace8 = new CsNamespace();
            ((ICsNamespace)_namespace8).NamespaceName = new CsIdentifier("Namespace9");
            var _attribute10 = new CsAttributeCollection();

            ((ICsNamespace)_namespace8).Attributes = _attribute10;
            var _alias11 = new CsExternAliasCollection();

            ((ICsNamespace)_namespace8).Aliases = _alias11;
            var _var11 = new CsNamespaceMemberCollection();
            var _class2 = new CsClass();
            ((ICsClass)_class2).ClassName = new CsIdentifier("_class2");
            var _gpar1 = new CsGenericParameterCollection();

            ((ICsGenericDeclaration)_class2).GenericParameters = _gpar1;
            var _attribute11 = new CsAttributeCollection();

            ((ICsAttributesProvider)_class2).Attributes = _attribute11;
            var _meth1 = new CsMethod();
            ((ICsMethod)_meth1).MethodName = new CsIdentifier("Main");
            var _gpar2 = new CsGenericParameterCollection();

            ((ICsGenericDeclaration)_meth1).GenericParameters = _gpar2;
            var _attribute13 = new CsAttributeCollection();

            ((ICsAttributesProvider)_meth1).Attributes = _attribute13;
            var _mod3 = new CsModifiers(ECsModifiers.Static);
            ((ICsModifiersProvider)_meth1).Modifiers = _mod3;
            var _constraint2 = new CsGenericConstraintCollection();

            ((ICsGenericDeclaration)_meth1).GenericConstraints = _constraint2;
            var _type9 = new CsVoid();
            var _garg2 = new CsGenericArgumentCollection();
            var _typrefs7 = new CsTypeReference(_type9, _garg2);
            ((ICsMethod)_meth1).TypeResult = _typrefs7; var _param2 = new CsParameterCollection();

            ((ICsMethod)_meth1).Parameters = _param2; var _block1 = new CsBlockStatementCollection(); var _garg15 = new CsGenericArgumentCollection();
            var _expression5 = new CsExpressionType(new CsTypeReference(typeof(System.Console)), _garg15); var _expression1 = new CsExpressionCall(); var _meth2 = new CsMethod();
            ((ICsMethod)_meth2).MethodName = new CsIdentifier("WriteLine");
            var _gpar3 = new CsGenericParameterCollection();

            ((ICsGenericDeclaration)_meth2).GenericParameters = _gpar3;
            var _attribute15 = new CsAttributeCollection();

            ((ICsAttributesProvider)_meth2).Attributes = _attribute15;
            var _mod4 = new CsModifiers();
            ((ICsModifiersProvider)_meth2).Modifiers = _mod4;
            var _constraint3 = new CsGenericConstraintCollection();

            ((ICsGenericDeclaration)_meth2).GenericConstraints = _constraint3;
            var _type15 = new CsVoid();
            var _garg3 = new CsGenericArgumentCollection();
            var _typrefs8 = new CsTypeReference(_type15, _garg3);
            ((ICsMethod)_meth2).TypeResult = _typrefs8; var _param3 = new CsParameterCollection();

            ((ICsMethod)_meth2).Parameters = _param3; var _block3 = new CsBlockStatementCollection(); var _block4 = new CsBlock(_block3);
            ((ICsMethod)_meth2).Body = _block4;
            var _garg5 = new CsGenericArgumentCollection();
            var _meth5 = new CsMethodReference(_meth2, _garg5); ((ICsExpressionCall)_expression1).Method = _meth5; var _arg1 = new CsArgumentCollection();
            var _lit1 = new CsLiteralString("message"); _lit1.Verbatim = ECsVerbatimIdentifier.NonVerbatim; var _expression2 = new CsExpressionLiteral(_lit1); var Variable26 = new CsIdentifier("Variable25"); var _type51 = new CsObject();
            var _garg11 = new CsGenericArgumentCollection();
            var _typrefs9 = new CsTypeReference(_type51, _garg11);
            var _typrefs4 = new CsTypeDecoration(_typrefs9, ECsTypeDecoration.None); var _var19 = new CsVariable(_typrefs4, Variable26, null, ECsConstant.NonConstant, ECsTypeAccess.None); var _var1 = new CsVariableReference(_var19);
            var _arg2 = new CsArgument(_var1, _expression2, ECsArgumentType.Expr, ECsInitialisationType.Expression);
            _arg1.Arguments.Add(_arg2);
            ((ICsExpressionCall)_expression1).Arguments = _arg1; var _expression6 = new CsExpressionQualifiedExpression(_expression5, _expression1, ECsObjectAccess.Reference); var _stat4 = new CsStatementExpression(_expression6);
            _block1.Statements.Add(_stat4);
            _garg15 = new CsGenericArgumentCollection();
            _expression5 = new CsExpressionType(new CsTypeReference(typeof(System.Console)), _garg15); var _expression7 = new CsExpressionCall(); var _meth3 = new CsMethod();
            ((ICsMethod)_meth3).MethodName = new CsIdentifier("ReadLine");
            var _gpar4 = new CsGenericParameterCollection();

            ((ICsGenericDeclaration)_meth3).GenericParameters = _gpar4;
            var _attribute17 = new CsAttributeCollection();

            ((ICsAttributesProvider)_meth3).Attributes = _attribute17;
            var _mod5 = new CsModifiers();
            ((ICsModifiersProvider)_meth3).Modifiers = _mod5;
            var _constraint4 = new CsGenericConstraintCollection();

            ((ICsGenericDeclaration)_meth3).GenericConstraints = _constraint4;
            var _type76 = new CsVoid();
            var _garg16 = new CsGenericArgumentCollection();
            var _typrefs10 = new CsTypeReference(_type76, _garg16);
            ((ICsMethod)_meth3).TypeResult = _typrefs10; var _param4 = new CsParameterCollection();

            ((ICsMethod)_meth3).Parameters = _param4; var _block5 = new CsBlockStatementCollection(); var _block6 = new CsBlock(_block5);
            ((ICsMethod)_meth3).Body = _block6;
            var _garg18 = new CsGenericArgumentCollection();
            var _meth6 = new CsMethodReference(_meth3, _garg18); ((ICsExpressionCall)_expression7).Method = _meth6; var _arg3 = new CsArgumentCollection();
            ((ICsExpressionCall)_expression7).Arguments = _arg3; var _expression8 = new CsExpressionQualifiedExpression(_expression5, _expression7, ECsObjectAccess.Reference); var _stat7 = new CsStatementExpression(_expression8);
            _block1.Statements.Add(_stat7);
            var _block2 = new CsBlock(_block1);
            ((ICsMethod)_meth1).Body = _block2;
            _class2.Body.Members.Add(_meth1);
            var _face1 = new CsInterfaceCollection();

            ((ICsClass)_class2).Interfaces = _face1;
            var _constraint1 = new CsGenericConstraintCollection();

            ((ICsGenericDeclaration)_class2).GenericConstraints = _constraint1;

            _var11.Members.Add(_class2);

            ((ICsNamespace)_namespace8).NamespaceMembers = _var11;
            var _using11 = new CsUsingCollection();
            ((ICsNamespace)_namespace8).Usings = _using11;

            _unit1.UnitMembers.Members.Add(_namespace8); var _namespace10 = new CsNamespace();
            ((ICsNamespace)_namespace10).NamespaceName = new CsIdentifier("Users");
            var _attribute19 = new CsAttributeCollection();

            ((ICsNamespace)_namespace10).Attributes = _attribute19;
            var _alias13 = new CsExternAliasCollection();

            ((ICsNamespace)_namespace10).Aliases = _alias13;
            var _var26 = new CsNamespaceMemberCollection();

            ((ICsNamespace)_namespace10).NamespaceMembers = _var26;
            var _using13 = new CsUsingCollection();
            ((ICsNamespace)_namespace10).Usings = _using13;

            _unit1.UnitMembers.Members.Add(_namespace10);



            //=======================================================================


            string code = ((ICsCode)_unit1).GenerateSourceCode();
            Console.WriteLine("==================================");
            Console.WriteLine(code);

            //CsExpressionType t1 = new CsExpressionType(new CsTypeReference(typeof(System.Console), ECsReflectInfoStatus.ExternalDll), null);
            //var t2 = new CsTypeReference(typeof(System.Console), ECsReflectInfoStatus.ExternalDll);
            //string s = ((ICsCode)t2).GenerateSourceCode();
            //Console.WriteLine(s);
            //Console.WriteLine("===========================================");
            //string ss = ((ICsCodeSelf)t2).GenerateSelfCode().Item2;
            //Console.WriteLine(ss);

            //var _typrefs1 = new CsTypeReference(typeof(System.Console), ECsReflectInfoStatus.ExternalDll);

            //s = ((ICsCode)t1).GenerateSourceCode();
            //Console.WriteLine(s);
            //Console.WriteLine("===========================================");
            //ss = ((ICsCodeSelf)t1).GenerateSelfCode().Item2;
            //Console.WriteLine(ss);

            //var _garg1 = new CsGenericArgumentCollection();
            //var _expression1 = new CsExpressionType(new CsTypeReference(typeof(System.Console)), _garg1);

            //s = (_typrefs1 as ICsCode).GenerateSourceCode();
            //Console.WriteLine(s);
            //Console.WriteLine("===========================================");
            //s = (_expression1 as ICsCode).GenerateSourceCode();
            //Console.WriteLine(s);
            //Console.WriteLine("===========================================");



            Console.ReadLine();
        }
    }
}

