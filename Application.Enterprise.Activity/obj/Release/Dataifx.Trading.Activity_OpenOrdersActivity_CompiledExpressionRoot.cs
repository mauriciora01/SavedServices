namespace Dataifx.Trading.Activity {
    
    #line 24 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\OpenOrdersActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class OpenOrdersActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext1 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Data.DataTable>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext2 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext4 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext5 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<System.Data.DataTable>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext6 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext7 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext8 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext9 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<System.Data.DataTable>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext11 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext12 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<System.Data.DataTable>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext13 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext14 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((OpenOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = OpenOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new OpenOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                OpenOrdersActivity_TypedDataContext2 refDataContext16 = ((OpenOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
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
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext0 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext1 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<System.Data.DataTable>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext2 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext3 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext4 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext5 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<System.Data.DataTable>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext6 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext7 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext8 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext9 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<System.Data.DataTable>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext10 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext11 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext12 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<System.Data.DataTable>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext13 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext14 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                OpenOrdersActivity_TypedDataContext2_ForReadOnly valDataContext15 = new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                OpenOrdersActivity_TypedDataContext2 refDataContext16 = new OpenOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Business.ParametroConfiguracion.Obtener(objUser)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtParametrosConf") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "objUser.Perfil == PerfilUsuario.TraderSoporte") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasMultiOrdenante(objUser)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOrders") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasTrader(objUser)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "objUser.Perfil == PerfilUsuario.TraderSoporte") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas" +
                            ")") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOrders") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasTrader(objUser)") 
                        && (OpenOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (OpenOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
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
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new OpenOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new OpenOrdersActivity_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OpenOrdersActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OpenOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OpenOrdersActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OpenOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class OpenOrdersActivity_TypedDataContext1 : OpenOrdersActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public OpenOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario objUser {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> MyOrders {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)(this.GetVariableValue((1 + locationsOffset))));
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
            
            protected override void GetValueTypeValues() {
                this.IdFirma = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
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
                if (((locationReferences[(offset + 0)].Name != "objUser") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MyOrders") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return OpenOrdersActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OpenOrdersActivity_TypedDataContext1_ForReadOnly : OpenOrdersActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public OpenOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario objUser {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> MyOrders {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "objUser") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MyOrders") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return OpenOrdersActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OpenOrdersActivity_TypedDataContext2 : OpenOrdersActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OpenOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtOrdenesAbiertas {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario Client {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((5 + locationsOffset))));
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
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 64 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
              dtParametrosConf;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr1Get() {
                
                #line 64 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
              dtParametrosConf;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(System.Data.DataTable value) {
                
                #line 64 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
              dtParametrosConf = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr5Get() {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(System.Data.DataTable value) {
                
                #line 175 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                        dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 157 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                            MyOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr7Get() {
                
                #line 157 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                            MyOrders;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                
                #line 157 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                            MyOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 143 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr9Get() {
                
                #line 143 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(System.Data.DataTable value) {
                
                #line 143 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                        dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr12Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(System.Data.DataTable value) {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                        dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 101 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                            MyOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr14Get() {
                
                #line 101 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                            MyOrders;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                
                #line 101 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                            MyOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr16Get() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(System.Data.DataTable value) {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                
                        dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
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
                if (((locationReferences[(offset + 3)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "dtOrdenesAbiertas") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Client") 
                            || (locationReferences[(offset + 5)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                return OpenOrdersActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class OpenOrdersActivity_TypedDataContext2_ForReadOnly : OpenOrdersActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public OpenOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public OpenOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtOrdenesAbiertas {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario Client {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((5 + locationsOffset))));
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
                
                #line 69 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
              Business.ParametroConfiguracion.Obtener(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr0Get() {
                
                #line 69 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
              Business.ParametroConfiguracion.Obtener(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 76 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 76 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
              IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 136 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 136 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Orden.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        Business.Orden.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 162 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                            Business.Orden.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr6Get() {
                
                #line 162 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                            Business.Orden.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 148 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr8Get() {
                
                #line 148 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr11Get() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 106 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                            Business.Correval.OrderRouting.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr13Get() {
                
                #line 106 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                            Business.Correval.OrderRouting.FillOpenOrders(dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr15Get() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\OPENORDERSACTIVITY.XAML"
                return 
                        Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
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
                if (((locationReferences[(offset + 3)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 3)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "dtOrdenesAbiertas") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Client") 
                            || (locationReferences[(offset + 5)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                return OpenOrdersActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
