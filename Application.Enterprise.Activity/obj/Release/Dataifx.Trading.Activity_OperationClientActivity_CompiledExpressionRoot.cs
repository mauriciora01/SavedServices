namespace Dataifx.Trading.Activity {
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 31 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 32 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 33 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 34 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OperationClientActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class OperationClientActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = OperationClientActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext2 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext4 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext6 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext7 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext8 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<System.Data.DataTable>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext10 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext11 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext12 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<System.Data.DataTable>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext13 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext14 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext16 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext17 = ((OperationClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OperationClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OperationClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                OperationClientActivity_TypedDataContext2 refDataContext18 = ((OperationClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
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
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext0 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext1 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                OperationClientActivity_TypedDataContext2 refDataContext2 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext3 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                OperationClientActivity_TypedDataContext2 refDataContext4 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext5 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext6 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext7 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                OperationClientActivity_TypedDataContext2 refDataContext8 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<System.Data.DataTable>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext9 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                OperationClientActivity_TypedDataContext2 refDataContext10 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext11 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                OperationClientActivity_TypedDataContext2 refDataContext12 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<System.Data.DataTable>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext13 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                OperationClientActivity_TypedDataContext2 refDataContext14 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext15 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                OperationClientActivity_TypedDataContext2 refDataContext16 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                OperationClientActivity_TypedDataContext2_ForReadOnly valDataContext17 = new OperationClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                OperationClientActivity_TypedDataContext2 refDataContext18 = new OperationClientActivity_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "strIdClient.Length > 0") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new InfoUsuario { Id = strUser }") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioweb") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.ParametroConfiguracion.Obtener(usuarioweb)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtParametrosConf") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "strIdClient.Length > 0") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.ConsultarOperacionesComercial(strUser,initialDate,finalDate,usua" +
                            "rioweb)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtROperaciones") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.FillOperationsClient(dtParametrosConf, dtROperaciones)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOperations") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.ConsultarOperaciones(strIdClient,initialDate,finalDate,usuariowe" +
                            "b)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtROperaciones") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "strIdClient.Replace(\',\',\'.\')") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIdClient") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.ConsultarOperaciones(Convert.ToDecimal(strIdClient), initialDate" +
                            ", finalDate, usuarioweb)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtROperaciones") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerInformacionBasica(strIdClient)") 
                        && (OperationClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "usuarioweb") 
                        && (OperationClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
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
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new OperationClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new OperationClientActivity_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OperationClientActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OperationClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OperationClientActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OperationClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OperationClientActivity_TypedDataContext1 : OperationClientActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime finalDate;
            
            protected System.DateTime initialDate;
            
            protected int IdFirma;
            
            public OperationClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdClient {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string strUser {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> MyOperations {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioweb {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
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
                this.finalDate = ((System.DateTime)(this.GetVariableValue((1 + locationsOffset))));
                this.initialDate = ((System.DateTime)(this.GetVariableValue((5 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.finalDate);
                this.SetVariableValue((5 + locationsOffset), this.initialDate);
                this.SetVariableValue((6 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 0)].Name != "strIdClient") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "strUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "MyOperations") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "usuarioweb") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "finalDate") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "initialDate") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IdFirma") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return OperationClientActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OperationClientActivity_TypedDataContext1_ForReadOnly : OperationClientActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.DateTime finalDate;
            
            protected System.DateTime initialDate;
            
            protected int IdFirma;
            
            public OperationClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdClient {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string strUser {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> MyOperations {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario usuarioweb {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
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
                this.finalDate = ((System.DateTime)(this.GetVariableValue((1 + locationsOffset))));
                this.initialDate = ((System.DateTime)(this.GetVariableValue((5 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 0)].Name != "strIdClient") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "strUser") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "MyOperations") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "usuarioweb") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "finalDate") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "initialDate") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IdFirma") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return OperationClientActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OperationClientActivity_TypedDataContext2 : OperationClientActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OperationClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtROperaciones {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
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
                
                #line 203 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                  usuarioweb;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr2Get() {
                
                #line 203 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                  usuarioweb;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 203 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                  usuarioweb = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                      dtParametrosConf;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                      dtParametrosConf;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Data.DataTable value) {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                      dtParametrosConf = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtROperaciones;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr8Get() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                dtROperaciones;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(System.Data.DataTable value) {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                                dtROperaciones = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>>> expression = () => 
                                    MyOperations;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> @__Expr10Get() {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                    MyOperations;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> value) {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                                    MyOperations = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtROperaciones;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr12Get() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                dtROperaciones;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(System.Data.DataTable value) {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                                dtROperaciones = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            strIdClient;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                            strIdClient;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                            strIdClient = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtROperaciones;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr16Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                dtROperaciones;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(System.Data.DataTable value) {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                                dtROperaciones = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 73 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                  usuarioweb;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr18Get() {
                
                #line 73 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                  usuarioweb;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 73 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                
                  usuarioweb = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "dtROperaciones") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return OperationClientActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OperationClientActivity_TypedDataContext2_ForReadOnly : OperationClientActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OperationClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OperationClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtROperaciones {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((8 + locationsOffset))));
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
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          strIdClient.Length > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
          strIdClient.Length > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 208 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                  new InfoUsuario { Id = strUser };
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr1Get() {
                
                #line 208 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                  new InfoUsuario { Id = strUser };
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                      Business.ParametroConfiguracion.Obtener(usuarioweb);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                      Business.ParametroConfiguracion.Obtener(usuarioweb);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                      IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 149 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        strIdClient.Length > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 149 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                        strIdClient.Length > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Cliente.ConsultarOperacionesComercial(strUser,initialDate,finalDate,usuarioweb);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr7Get() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                Business.Cliente.ConsultarOperacionesComercial(strUser,initialDate,finalDate,usuarioweb);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 138 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation>>> expression = () => 
                                    Business.Cliente.FillOperationsClient(dtParametrosConf, dtROperaciones);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> @__Expr9Get() {
                
                #line 138 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                    Business.Cliente.FillOperationsClient(dtParametrosConf, dtROperaciones);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Operation> ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Cliente.ConsultarOperaciones(strIdClient,initialDate,finalDate,usuarioweb);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr11Get() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                Business.Cliente.ConsultarOperaciones(strIdClient,initialDate,finalDate,usuarioweb);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 110 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            strIdClient.Replace(',','.');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 110 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                            strIdClient.Replace(',','.');
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Cliente.ConsultarOperaciones(Convert.ToDecimal(strIdClient), initialDate, finalDate, usuarioweb);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr15Get() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                                Business.Cliente.ConsultarOperaciones(Convert.ToDecimal(strIdClient), initialDate, finalDate, usuarioweb);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 78 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                  Business.Usuario.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr17Get() {
                
                #line 78 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPERATIONCLIENTACTIVITY.XAML"
                return 
                  Business.Usuario.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 9))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 9);
                }
                expectedLocationsCount = 9;
                if (((locationReferences[(offset + 7)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "dtROperaciones") 
                            || (locationReferences[(offset + 8)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return OperationClientActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
