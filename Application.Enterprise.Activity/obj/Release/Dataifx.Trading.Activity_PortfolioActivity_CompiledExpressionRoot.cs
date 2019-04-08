namespace Dataifx.Trading.Activity {
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 31 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using Dataifx.Trading.Business;
    
    #line default
    #line hidden
    
    #line 32 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using Dataifx.Trading.Business.Correval;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\PortfolioActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class PortfolioActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = PortfolioActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext2 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext4 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext6 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<System.Data.DataTable>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext7 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext8 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext11 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext12 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext13 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext14 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext15 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext16 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext17 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext18 = ((PortfolioActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = PortfolioActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new PortfolioActivity_TypedDataContext2(locations, activityContext, true);
                }
                PortfolioActivity_TypedDataContext2 refDataContext19 = ((PortfolioActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<System.Data.DataTable>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
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
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext0 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext1 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                PortfolioActivity_TypedDataContext2 refDataContext2 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext3 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                PortfolioActivity_TypedDataContext2 refDataContext4 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext5 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                PortfolioActivity_TypedDataContext2 refDataContext6 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<System.Data.DataTable>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext7 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                PortfolioActivity_TypedDataContext2 refDataContext8 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<double>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext9 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext10 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                PortfolioActivity_TypedDataContext2 refDataContext11 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext12 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                PortfolioActivity_TypedDataContext2 refDataContext13 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext14 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                PortfolioActivity_TypedDataContext2 refDataContext15 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext16 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                PortfolioActivity_TypedDataContext2 refDataContext17 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                PortfolioActivity_TypedDataContext2_ForReadOnly valDataContext18 = new PortfolioActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                PortfolioActivity_TypedDataContext2 refDataContext19 = new PortfolioActivity_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<System.Data.DataTable>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerInformacionBasica(strIdCliente)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Myusuario") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DetalleInventario.ObtenerValoracionPortafolioPorCtaDeceval(Myusuario, Myusuario, " +
                            "Convert.ToInt32(strCtaDeceval))") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtValoration") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Instrumento.ObtenerComportamientoMercado(DateTime.Now, Myusuario)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtMercado") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DetalleInventario.ObtenerComisionFija(Myusuario)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "valorComisionFija") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DetalleInventario.FillPortfolio(strIdCliente, Myusuario, dtMercado, dtValoration," +
                            " valorComisionFija)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AllPortfolio") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.PortfolioClient.FillPortfolio(strIdCliente, Myusuario, dtMercad" +
                            "o, dtValoration, valorComisionFija)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AllPortfolio") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "strIdCliente.Replace(\',\',\'.\')") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIdCliente") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerInformacionBasica(strIdCliente)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Myusuario") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.PortfolioClient.ObtenerValoracionPortafolioByCliente(strIdClien" +
                            "te,Myusuario)") 
                        && (PortfolioActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtValoration") 
                        && (PortfolioActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
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
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new PortfolioActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new PortfolioActivity_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PortfolioActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class PortfolioActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public PortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class PortfolioActivity_TypedDataContext1 : PortfolioActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public PortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdCliente {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string strCtaDeceval {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> AllPortfolio {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>)(this.GetVariableValue((2 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "strIdCliente") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strCtaDeceval") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "AllPortfolio") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return PortfolioActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PortfolioActivity_TypedDataContext1_ForReadOnly : PortfolioActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public PortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdCliente {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string strCtaDeceval {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> AllPortfolio {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>)(this.GetVariableValue((2 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "strIdCliente") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strCtaDeceval") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "AllPortfolio") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return PortfolioActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PortfolioActivity_TypedDataContext2 : PortfolioActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double valorComisionFija;
            
            public PortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario Myusuario {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtMercado {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtValoration {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
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
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                Myusuario;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr2Get() {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                Myusuario;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                Myusuario = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    dtValoration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                    dtValoration;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Data.DataTable value) {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                    dtValoration = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtMercado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr6Get() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                        dtMercado;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(System.Data.DataTable value) {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                        dtMercado = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            valorComisionFija;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                            valorComisionFija;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(double value) {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                            valorComisionFija = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>> expression = () => 
                                  AllPortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> @__Expr11Get() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                                  AllPortfolio;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> value) {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                                  AllPortfolio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>> expression = () => 
                                  AllPortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> @__Expr13Get() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                                  AllPortfolio;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> value) {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                                  AllPortfolio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                strIdCliente;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                strIdCliente;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(string value) {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                strIdCliente = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Myusuario;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr17Get() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                    Myusuario;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                    Myusuario = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        dtValoration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr19Get() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                        dtValoration;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(System.Data.DataTable value) {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                
                        dtValoration = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.valorComisionFija = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((7 + locationsOffset), this.valorComisionFija);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 4)].Name != "Myusuario") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtMercado") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "dtValoration") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "valorComisionFija") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return PortfolioActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class PortfolioActivity_TypedDataContext2_ForReadOnly : PortfolioActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected double valorComisionFija;
            
            public PortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public PortfolioActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario Myusuario {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtMercado {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtValoration {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((6 + locationsOffset))));
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
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 66 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
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
                
                #line 77 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                Business.Usuario.ObtenerInformacionBasica(strIdCliente);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr1Get() {
                
                #line 77 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                Business.Usuario.ObtenerInformacionBasica(strIdCliente);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    DetalleInventario.ObtenerValoracionPortafolioPorCtaDeceval(Myusuario, Myusuario, Convert.ToInt32(strCtaDeceval));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                    DetalleInventario.ObtenerValoracionPortafolioPorCtaDeceval(Myusuario, Myusuario, Convert.ToInt32(strCtaDeceval));
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Instrumento.ObtenerComportamientoMercado(DateTime.Now, Myusuario);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr5Get() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                        Business.Instrumento.ObtenerComportamientoMercado(DateTime.Now, Myusuario);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                            DetalleInventario.ObtenerComisionFija(Myusuario);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr7Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                            DetalleInventario.ObtenerComisionFija(Myusuario);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr9Get() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                            IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>> expression = () => 
                                  DetalleInventario.FillPortfolio(strIdCliente, Myusuario, dtMercado, dtValoration, valorComisionFija);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> @__Expr10Get() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                                  DetalleInventario.FillPortfolio(strIdCliente, Myusuario, dtMercado, dtValoration, valorComisionFija);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio>>> expression = () => 
                                  Business.Correval.PortfolioClient.FillPortfolio(strIdCliente, Myusuario, dtMercado, dtValoration, valorComisionFija);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> @__Expr12Get() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                                  Business.Correval.PortfolioClient.FillPortfolio(strIdCliente, Myusuario, dtMercado, dtValoration, valorComisionFija);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Portfolio> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                strIdCliente.Replace(',','.');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                strIdCliente.Replace(',','.');
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Business.Correval.User.ObtenerInformacionBasica(strIdCliente);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr16Get() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                    Business.Correval.User.ObtenerInformacionBasica(strIdCliente);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                        Business.Correval.PortfolioClient.ObtenerValoracionPortafolioByCliente(strIdCliente,Myusuario);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr18Get() {
                
                #line 204 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\PORTFOLIOACTIVITY.XAML"
                return 
                        Business.Correval.PortfolioClient.ObtenerValoracionPortafolioByCliente(strIdCliente,Myusuario);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            protected override void GetValueTypeValues() {
                this.valorComisionFija = ((double)(this.GetVariableValue((7 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 4)].Name != "Myusuario") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtMercado") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "dtValoration") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "valorComisionFija") 
                            || (locationReferences[(offset + 7)].Type != typeof(double)))) {
                    return false;
                }
                return PortfolioActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
