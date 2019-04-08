namespace Dataifx.Trading.Activity {
    
    #line 22 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AccountDemoActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class AccountDemoActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = AccountDemoActivity_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AccountDemoActivity_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext0 = ((AccountDemoActivity_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AccountDemoActivity_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext1 = ((AccountDemoActivity_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AccountDemoActivity_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AccountDemoActivity_TypedDataContext1(locations, activityContext, true);
                }
                AccountDemoActivity_TypedDataContext1 refDataContext2 = ((AccountDemoActivity_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<bool>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AccountDemoActivity_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext3 = ((AccountDemoActivity_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AccountDemoActivity_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AccountDemoActivity_TypedDataContext1(locations, activityContext, true);
                }
                AccountDemoActivity_TypedDataContext1 refDataContext4 = ((AccountDemoActivity_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<bool>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext0 = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext1 = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                AccountDemoActivity_TypedDataContext1 refDataContext2 = new AccountDemoActivity_TypedDataContext1(locations, true);
                return refDataContext2.GetLocation<bool>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                AccountDemoActivity_TypedDataContext1_ForReadOnly valDataContext3 = new AccountDemoActivity_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                AccountDemoActivity_TypedDataContext1 refDataContext4 = new AccountDemoActivity_TypedDataContext1(locations, true);
                return refDataContext4.GetLocation<bool>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AccountDemoActivity_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Business.Demo().RegistarCuentaDemo(demoAccount)") 
                        && (AccountDemoActivity_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (AccountDemoActivity_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Business.Correval.Demo().RegistarCuentaDemo(demoAccount)") 
                        && (AccountDemoActivity_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "resultado") 
                        && (AccountDemoActivity_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new AccountDemoActivity_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new AccountDemoActivity_TypedDataContext1_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new AccountDemoActivity_TypedDataContext1(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new AccountDemoActivity_TypedDataContext1_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new AccountDemoActivity_TypedDataContext1(locationReferences).@__Expr4GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AccountDemoActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AccountDemoActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AccountDemoActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AccountDemoActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AccountDemoActivity_TypedDataContext1 : AccountDemoActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool resultado;
            
            protected int IdFirma;
            
            public AccountDemoActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.DemoAccount demoAccount {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.DemoAccount)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 61 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 61 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                return 
                resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(bool value) {
                
                #line 61 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                
                resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 75 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                resultado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 75 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                return 
                resultado;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(bool value) {
                
                #line 75 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                
                resultado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.resultado = ((bool)(this.GetVariableValue((0 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.resultado);
                this.SetVariableValue((2 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "demoAccount") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.Infrastructure.Models.DemoAccount)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "resultado") 
                            || (locationReferences[(offset + 0)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return AccountDemoActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AccountDemoActivity_TypedDataContext1_ForReadOnly : AccountDemoActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool resultado;
            
            protected int IdFirma;
            
            public AccountDemoActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AccountDemoActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.DemoAccount demoAccount {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.DemoAccount)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 55 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 55 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                return 
          IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                new Business.Demo().RegistarCuentaDemo(demoAccount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                return 
                new Business.Demo().RegistarCuentaDemo(demoAccount);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                new Business.Correval.Demo().RegistarCuentaDemo(demoAccount);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ACCOUNTDEMOACTIVITY.XAML"
                return 
                new Business.Correval.Demo().RegistarCuentaDemo(demoAccount);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            protected override void GetValueTypeValues() {
                this.resultado = ((bool)(this.GetVariableValue((0 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "demoAccount") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.Infrastructure.Models.DemoAccount)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "resultado") 
                            || (locationReferences[(offset + 0)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return AccountDemoActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
