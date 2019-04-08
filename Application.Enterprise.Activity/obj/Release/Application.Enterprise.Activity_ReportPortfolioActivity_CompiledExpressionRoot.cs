namespace Application.Enterprise.Activity {
    
    #line 25 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 26 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 27 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 28 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 29 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 30 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using Application.Enterprise.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\ProyectosVS\TradingSolution\Application.Enterprise.Activity\ReportPortfolioActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class ReportPortfolioActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = ReportPortfolioActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((ReportPortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((ReportPortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ReportPortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2 refDataContext2 = ((ReportPortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<System.Data.DataTable>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((ReportPortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ReportPortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2 refDataContext4 = ((ReportPortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((ReportPortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ReportPortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ReportPortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                ReportPortfolioActivity_TypedDataContext2 refDataContext6 = ((ReportPortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
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
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext0 = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext1 = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                ReportPortfolioActivity_TypedDataContext2 refDataContext2 = new ReportPortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<System.Data.DataTable>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext3 = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                ReportPortfolioActivity_TypedDataContext2 refDataContext4 = new ReportPortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                ReportPortfolioActivity_TypedDataContext2_ForReadOnly valDataContext5 = new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                ReportPortfolioActivity_TypedDataContext2 refDataContext6 = new ReportPortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (ReportPortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComerci" +
                            "al)") 
                        && (ReportPortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtPortfolio") 
                        && (ReportPortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComerci" +
                            "al)") 
                        && (ReportPortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtMercado") 
                        && (ReportPortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "MyPortfolio") 
                        && (ReportPortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyPortfolio") 
                        && (ReportPortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
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
                return new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new ReportPortfolioActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new ReportPortfolioActivity_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new ReportPortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new ReportPortfolioActivity_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ReportPortfolioActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ReportPortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class ReportPortfolioActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ReportPortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class ReportPortfolioActivity_TypedDataContext1 : ReportPortfolioActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public ReportPortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdComercial {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> MyPortfolio {
                get {
                    return ((System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected Application.Enterprise.CommonObjects.InfoUsuario MyUser {
                get {
                    return ((Application.Enterprise.CommonObjects.InfoUsuario)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((3 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "strIdComercial") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MyPortfolio") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "MyUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(Application.Enterprise.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return ReportPortfolioActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ReportPortfolioActivity_TypedDataContext1_ForReadOnly : ReportPortfolioActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public ReportPortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdComercial {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> MyPortfolio {
                get {
                    return ((System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected Application.Enterprise.CommonObjects.InfoUsuario MyUser {
                get {
                    return ((Application.Enterprise.CommonObjects.InfoUsuario)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.IdFirma = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "strIdComercial") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MyPortfolio") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "MyUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(Application.Enterprise.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return ReportPortfolioActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ReportPortfolioActivity_TypedDataContext2 : ReportPortfolioActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ReportPortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtMercado {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtPortfolio {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
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
                
                #line 69 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                dtPortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr2Get() {
                
                #line 69 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                dtPortfolio;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(System.Data.DataTable value) {
                
                #line 69 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                
                dtPortfolio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 83 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    dtMercado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 83 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                    dtMercado;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Data.DataTable value) {
                
                #line 83 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                
                    dtMercado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 97 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>>> expression = () => 
                        MyPortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> @__Expr6Get() {
                
                #line 97 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                        MyPortfolio;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> value) {
                
                #line 97 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                
                        MyPortfolio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 4)].Name != "dtMercado") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtPortfolio") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return ReportPortfolioActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ReportPortfolioActivity_TypedDataContext2_ForReadOnly : ReportPortfolioActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ReportPortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ReportPortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtMercado {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtPortfolio {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
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
                
                #line 63 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 63 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
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
                
                #line 74 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComercial);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr1Get() {
                
                #line 74 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComercial);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 88 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComercial);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 88 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                    Business.ConfiguracionInstrumentos.EliminarConfiguracionIntrumentos1(strIdComercial);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 102 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion>>> expression = () => 
                        MyPortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> @__Expr5Get() {
                
                #line 102 "C:\PROYECTOSVS\TRADINGSOLUTION\APPLICATION.ENTERPRISE.ACTIVITY\REPORTPORTFOLIOACTIVITY.XAML"
                return 
                        MyPortfolio;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Application.Enterprise.CommonObjects.ParametroConfiguracion> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 4)].Name != "dtMercado") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtPortfolio") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return ReportPortfolioActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
