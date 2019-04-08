namespace Dataifx.Trading.Activity {
    
    #line 33 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 34 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 35 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 36 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 37 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 38 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 39 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AutenticationActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class AutenticationActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = AutenticationActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext2 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext4 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext5 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<System.Data.DataTable>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext6 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext7 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext8 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext10 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<Dataifx.Trading.CommonObjects.EstadoUsuario>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext11 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext12 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext13 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext14 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext16 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext17 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext18 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext19 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext20 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext21 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext21.GetLocation<System.Data.DataTable>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext22 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext23 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext24 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext25 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext26 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext27 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext28 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext29 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<System.Data.DataTable>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext30 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext31 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<System.Data.DataTable>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext32 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext33 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext34 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext35 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext36 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext37 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext38 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext39 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext40 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext41 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext42 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext43 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext44 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext44.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext45 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext46 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext47 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext48 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext49 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext50 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext51 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext51.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext52 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext53 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext54 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext55 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext55.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext56 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext57 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext57.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext58 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext59 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext59.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext60 = ((AutenticationActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AutenticationActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AutenticationActivity_TypedDataContext2(locations, activityContext, true);
                }
                AutenticationActivity_TypedDataContext2 refDataContext61 = ((AutenticationActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext61.GetLocation<System.Data.DataTable>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set, expressionId, this.rootActivity, activityContext);
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
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext0 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext1 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                AutenticationActivity_TypedDataContext2 refDataContext2 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext3 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext4 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                AutenticationActivity_TypedDataContext2 refDataContext5 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<System.Data.DataTable>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext6 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                AutenticationActivity_TypedDataContext2 refDataContext7 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext8 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext9 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                AutenticationActivity_TypedDataContext2 refDataContext10 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<Dataifx.Trading.CommonObjects.EstadoUsuario>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext11 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext12 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext13 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                AutenticationActivity_TypedDataContext2 refDataContext14 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext15 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                AutenticationActivity_TypedDataContext2 refDataContext16 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext17 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext18 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                AutenticationActivity_TypedDataContext2 refDataContext19 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext20 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                AutenticationActivity_TypedDataContext2 refDataContext21 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext21.GetLocation<System.Data.DataTable>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext22 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext23 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                AutenticationActivity_TypedDataContext2 refDataContext24 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext25 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                AutenticationActivity_TypedDataContext2 refDataContext26 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext27 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext28 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                AutenticationActivity_TypedDataContext2 refDataContext29 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<System.Data.DataTable>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext30 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                AutenticationActivity_TypedDataContext2 refDataContext31 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<System.Data.DataTable>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext32 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                AutenticationActivity_TypedDataContext2 refDataContext33 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<string>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext34 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext35 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext36 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext37 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                AutenticationActivity_TypedDataContext2 refDataContext38 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext38.GetLocation<bool>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext39 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext40 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext41 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext42 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext43 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                AutenticationActivity_TypedDataContext2 refDataContext44 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext44.GetLocation<Dataifx.Trading.CommonObjects.PerfilUsuario>(refDataContext44.ValueType___Expr44Get, refDataContext44.ValueType___Expr44Set);
            }
            if ((expressionId == 45)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext45 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext45.ValueType___Expr45Get();
            }
            if ((expressionId == 46)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext46 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext47 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext48 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext49 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext50 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                AutenticationActivity_TypedDataContext2 refDataContext51 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext51.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext52 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext53 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext54 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                AutenticationActivity_TypedDataContext2 refDataContext55 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext55.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext55.ValueType___Expr55Get, refDataContext55.ValueType___Expr55Set);
            }
            if ((expressionId == 56)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext56 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext56.ValueType___Expr56Get();
            }
            if ((expressionId == 57)) {
                AutenticationActivity_TypedDataContext2 refDataContext57 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext57.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext57.ValueType___Expr57Get, refDataContext57.ValueType___Expr57Set);
            }
            if ((expressionId == 58)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext58 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext58.ValueType___Expr58Get();
            }
            if ((expressionId == 59)) {
                AutenticationActivity_TypedDataContext2 refDataContext59 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext59.GetLocation<Dataifx.Trading.CommonObjects.EstadoAutenticacion>(refDataContext59.ValueType___Expr59Get, refDataContext59.ValueType___Expr59Set);
            }
            if ((expressionId == 60)) {
                AutenticationActivity_TypedDataContext2_ForReadOnly valDataContext60 = new AutenticationActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext60.ValueType___Expr60Get();
            }
            if ((expressionId == 61)) {
                AutenticationActivity_TypedDataContext2 refDataContext61 = new AutenticationActivity_TypedDataContext2(locations, true);
                return refDataContext61.GetLocation<System.Data.DataTable>(refDataContext61.ValueType___Expr61Get, refDataContext61.ValueType___Expr61Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new DataTable()") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EstadoAutenticacion.UsuarioClaveNoValidos") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "autenticationState") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillUser(strIdUser)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datos") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.GetEmail(datos)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "UserEmail") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "datos.Rows.Count > 0") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(CommonObjects.EstadoUsuario)Convert.ToChar(datos.Rows[0][\"Estado\"].ToString())") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "eu") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "eu != EstadoUsuario.Activo") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "validatepassword==true") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EstadoAutenticacion.AutenticacionSatisfactoria") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "autenticationState") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillInfoUser(iu, datos)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "perfil") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "perfil == PerfilUsuario.TraderSoporte") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(datos.Columns.Contains(\"RequiereToken\")) ? Convert.ToBoolean(datos.Rows[0][\"Requ" +
                            "iereToken\"]) : false;") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ValidateOTP") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillOrdenante(strIdUser)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenante") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows.Count == 1") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows[0][\"Nombres\"].ToString() + \" \" + dtOrdenante.Rows[0][\"Apellidos\"" +
                            "].ToString()") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iu.InfoCliente.NombreOrdenante") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows[0][\"IdCliente\"].ToString()") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iu.InfoCliente.Id") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.FillClientJuridico((decimal)dtOrdenante.Rows[0][\"IdCliente" +
                            "\"])") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtClienteJuridico") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.FillClientNatural((decimal)dtOrdenante.Rows[0][\"IdCliente\"" +
                            "])") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtClienteNatural") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(datos.Columns.Contains(\"NumeroDocumento\")) ? datos.Rows[0][\"NumeroDocumento\"].To" +
                            "String() : \"\";") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NumeroDocumento") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "(decimal)dtOrdenante.Rows[0][\"IdCliente\"]") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtClienteJuridico") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtClienteNatural") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iu.IsCertified") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "perfil == PerfilUsuario.Institucional") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows[0][\"IdCliente\"].ToString()") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows.Count > 1 && iu.Perfil != PerfilUsuario.Institucional && iu.Perf" +
                            "il != PerfilUsuario.Demo") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "PerfilUsuario.MultiOrdenante") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iu.Perfil") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dtOrdenante.Rows[0][\"IdCliente\"].ToString()") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.IpAddress.IsValidLocalIpAddress(strIdUser,strIpAddress)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EstadoAutenticacion.IpInvalidaParaPerfil") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "autenticationState") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ValidatePassword(strPassword, (string)datos.Rows[0][\"Hash\"], (st" +
                            "ring)datos.Rows[0][\"Salt\"])") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.UpdateFailedAttempts(strIdUser, Convert.ToInt32(datos.Rows[0][\"N" +
                            "umVecesErrado\"]))") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "autenticationState") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "iu") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EstadoAutenticacion.UsuarioBloqueado") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "autenticationState") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillUserDavHb(strIdUser)") 
                        && (AutenticationActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "datos") 
                        && (AutenticationActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
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
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new AutenticationActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new AutenticationActivity_TypedDataContext2(locationReferences).@__Expr61GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AutenticationActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AutenticationActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class AutenticationActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AutenticationActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class AutenticationActivity_TypedDataContext1 : AutenticationActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected Dataifx.Trading.CommonObjects.EstadoAutenticacion autenticationState;
            
            protected bool ValidateOTP;
            
            protected bool validatepassword;
            
            protected int IdFirma;
            
            public AutenticationActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string NumeroDocumento {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string argument1 {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string strIpAddress {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string strPassword {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string strIdUser {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string UserEmail {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario iu {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((10 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((10 + locationsOffset), value);
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
                this.autenticationState = ((Dataifx.Trading.CommonObjects.EstadoAutenticacion)(this.GetVariableValue((0 + locationsOffset))));
                this.ValidateOTP = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.validatepassword = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.autenticationState);
                this.SetVariableValue((1 + locationsOffset), this.ValidateOTP);
                this.SetVariableValue((8 + locationsOffset), this.validatepassword);
                this.SetVariableValue((9 + locationsOffset), this.IdFirma);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 2)].Name != "NumeroDocumento") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "argument1") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "strIpAddress") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "strPassword") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "strIdUser") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "UserEmail") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "iu") 
                            || (locationReferences[(offset + 10)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "autenticationState") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.CommonObjects.EstadoAutenticacion)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "ValidateOTP") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "validatepassword") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "IdFirma") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return AutenticationActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AutenticationActivity_TypedDataContext1_ForReadOnly : AutenticationActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected Dataifx.Trading.CommonObjects.EstadoAutenticacion autenticationState;
            
            protected bool ValidateOTP;
            
            protected bool validatepassword;
            
            protected int IdFirma;
            
            public AutenticationActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string NumeroDocumento {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string argument1 {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string strIpAddress {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string strPassword {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string strIdUser {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string UserEmail {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario iu {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((10 + locationsOffset))));
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
                this.autenticationState = ((Dataifx.Trading.CommonObjects.EstadoAutenticacion)(this.GetVariableValue((0 + locationsOffset))));
                this.ValidateOTP = ((bool)(this.GetVariableValue((1 + locationsOffset))));
                this.validatepassword = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 2)].Name != "NumeroDocumento") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "argument1") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "strIpAddress") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "strPassword") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "strIdUser") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "UserEmail") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "iu") 
                            || (locationReferences[(offset + 10)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "autenticationState") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.CommonObjects.EstadoAutenticacion)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "ValidateOTP") 
                            || (locationReferences[(offset + 1)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "validatepassword") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "IdFirma") 
                            || (locationReferences[(offset + 9)].Type != typeof(int)))) {
                    return false;
                }
                return AutenticationActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AutenticationActivity_TypedDataContext2 : AutenticationActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected Dataifx.Trading.CommonObjects.EstadoUsuario eu;
            
            protected Dataifx.Trading.CommonObjects.PerfilUsuario perfil;
            
            public AutenticationActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable datos {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((11 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((11 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtOrdenante {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((14 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((14 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtClienteJuridico {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtClienteNatural {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((16 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((16 + locationsOffset), value);
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
                
                #line 82 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
              autenticationState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr2Get() {
                
                #line 82 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
              autenticationState;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                
                #line 82 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
              autenticationState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 98 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                      datos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr5Get() {
                
                #line 98 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                      datos;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(System.Data.DataTable value) {
                
                #line 98 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                      datos = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        UserEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                        UserEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 133 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                        UserEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 152 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoUsuario>> expression = () => 
                                eu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoUsuario @__Expr10Get() {
                
                #line 152 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                eu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoUsuario ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(Dataifx.Trading.CommonObjects.EstadoUsuario value) {
                
                #line 152 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                eu = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(Dataifx.Trading.CommonObjects.EstadoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 213 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                autenticationState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr14Get() {
                
                #line 213 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                autenticationState;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                
                #line 213 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                autenticationState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                                                    perfil;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr16Get() {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                    perfil;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                
                #line 227 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                    perfil = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 292 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            ValidateOTP;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 292 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                            ValidateOTP;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(bool value) {
                
                #line 292 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                            ValidateOTP = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 306 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                dtOrdenante;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr21Get() {
                
                #line 306 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                dtOrdenante;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(System.Data.DataTable value) {
                
                #line 306 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                dtOrdenante = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          iu.InfoCliente.NombreOrdenante;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                          iu.InfoCliente.NombreOrdenante;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(string value) {
                
                #line 326 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                          iu.InfoCliente.NombreOrdenante = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          iu.InfoCliente.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                          iu.InfoCliente.Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                          iu.InfoCliente.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 427 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                dtClienteJuridico;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr29Get() {
                
                #line 427 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                dtClienteJuridico;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(System.Data.DataTable value) {
                
                #line 427 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                                dtClienteJuridico = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 439 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                dtClienteNatural;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr31Get() {
                
                #line 439 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                dtClienteNatural;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(System.Data.DataTable value) {
                
                #line 439 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                                dtClienteNatural = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 454 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  NumeroDocumento;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 454 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                  NumeroDocumento;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(string value) {
                
                #line 454 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                                  NumeroDocumento = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                              iu.IsCertified;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                              iu.IsCertified;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(bool value) {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                                              iu.IsCertified = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 377 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                                                                                          iu.Perfil;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr44Get() {
                
                #line 377 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                          iu.Perfil;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr44Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                
                #line 377 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                                          iu.Perfil = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr44Set(Dataifx.Trading.CommonObjects.PerfilUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr44Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 271 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                                  autenticationState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr51Get() {
                
                #line 271 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                  autenticationState;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                
                #line 271 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                                  autenticationState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 510 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                autenticationState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr55Get() {
                
                #line 510 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                autenticationState;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr55Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                
                #line 510 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                                autenticationState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr55Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                this.GetValueTypeValues();
                this.@__Expr55Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                            iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr57Get() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                            iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr57Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                            iu = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr57Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr57Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                        autenticationState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr59Get() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                        autenticationState;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr59Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                                        autenticationState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr59Set(Dataifx.Trading.CommonObjects.EstadoAutenticacion value) {
                this.GetValueTypeValues();
                this.@__Expr59Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    datos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr61Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                    datos;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr61Set(System.Data.DataTable value) {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                
                    datos = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr61Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr61Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.eu = ((Dataifx.Trading.CommonObjects.EstadoUsuario)(this.GetVariableValue((12 + locationsOffset))));
                this.perfil = ((Dataifx.Trading.CommonObjects.PerfilUsuario)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((12 + locationsOffset), this.eu);
                this.SetVariableValue((13 + locationsOffset), this.perfil);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "datos") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "dtOrdenante") 
                            || (locationReferences[(offset + 14)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "dtClienteJuridico") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "dtClienteNatural") 
                            || (locationReferences[(offset + 16)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "eu") 
                            || (locationReferences[(offset + 12)].Type != typeof(Dataifx.Trading.CommonObjects.EstadoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "perfil") 
                            || (locationReferences[(offset + 13)].Type != typeof(Dataifx.Trading.CommonObjects.PerfilUsuario)))) {
                    return false;
                }
                return AutenticationActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AutenticationActivity_TypedDataContext2_ForReadOnly : AutenticationActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected Dataifx.Trading.CommonObjects.EstadoUsuario eu;
            
            protected Dataifx.Trading.CommonObjects.PerfilUsuario perfil;
            
            public AutenticationActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AutenticationActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable datos {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((11 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtOrdenante {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((14 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtClienteJuridico {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtClienteNatural {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((16 + locationsOffset))));
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
                
                #line 68 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
          new DataTable();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr0Get() {
                
                #line 68 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
          new DataTable();
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
              EstadoAutenticacion.UsuarioClaveNoValidos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr1Get() {
                
                #line 87 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
              EstadoAutenticacion.UsuarioClaveNoValidos;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 113 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 113 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
              IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 103 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                      Business.Usuario.FillUser(strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 103 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                      Business.Usuario.FillUser(strIdUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 138 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        Business.Usuario.GetEmail(datos);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 138 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                        Business.Usuario.GetEmail(datos);
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 145 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        datos.Rows.Count > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 145 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                        datos.Rows.Count > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 157 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoUsuario>> expression = () => 
                                (CommonObjects.EstadoUsuario)Convert.ToChar(datos.Rows[0]["Estado"].ToString());
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoUsuario @__Expr9Get() {
                
                #line 157 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                (CommonObjects.EstadoUsuario)Convert.ToChar(datos.Rows[0]["Estado"].ToString());
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoUsuario ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 164 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                eu != EstadoUsuario.Activo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 164 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                eu != EstadoUsuario.Activo;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 201 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                    validatepassword==true;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 201 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                    validatepassword==true;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 218 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                EstadoAutenticacion.AutenticacionSatisfactoria;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr13Get() {
                
                #line 218 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                EstadoAutenticacion.AutenticacionSatisfactoria;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 232 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                                                    Business.Usuario.FillInfoUser(iu, datos);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr15Get() {
                
                #line 232 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                    Business.Usuario.FillInfoUser(iu, datos);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 239 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                    perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 239 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                    perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 297 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                            (datos.Columns.Contains("RequiereToken")) ? Convert.ToBoolean(datos.Rows[0]["RequiereToken"]) : false;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 297 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                            (datos.Columns.Contains("RequiereToken")) ? Convert.ToBoolean(datos.Rows[0]["RequiereToken"]) : false;;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 311 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                Business.Usuario.FillOrdenante(strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr20Get() {
                
                #line 311 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                Business.Usuario.FillOrdenante(strIdUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 318 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                dtOrdenante.Rows.Count == 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 318 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                dtOrdenante.Rows.Count == 1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 331 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          dtOrdenante.Rows[0]["Nombres"].ToString() + " " + dtOrdenante.Rows[0]["Apellidos"].ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 331 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                          dtOrdenante.Rows[0]["Nombres"].ToString() + " " + dtOrdenante.Rows[0]["Apellidos"].ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 343 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                          dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 343 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                          dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 351 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                                        IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr27Get() {
                
                #line 351 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                        IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 432 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                Business.Correval.User.FillClientJuridico((decimal)dtOrdenante.Rows[0]["IdCliente"]);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr28Get() {
                
                #line 432 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                Business.Correval.User.FillClientJuridico((decimal)dtOrdenante.Rows[0]["IdCliente"]);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 444 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                Business.Correval.User.FillClientNatural((decimal)dtOrdenante.Rows[0]["IdCliente"]);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr30Get() {
                
                #line 444 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                Business.Correval.User.FillClientNatural((decimal)dtOrdenante.Rows[0]["IdCliente"]);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 459 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                  (datos.Columns.Contains("NumeroDocumento")) ? datos.Rows[0]["NumeroDocumento"].ToString() : "";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 459 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                  (datos.Columns.Contains("NumeroDocumento")) ? datos.Rows[0]["NumeroDocumento"].ToString() : "";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 476 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                                    (decimal)dtOrdenante.Rows[0]["IdCliente"];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr34Get() {
                
                #line 476 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                    (decimal)dtOrdenante.Rows[0]["IdCliente"];
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 473 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                    dtClienteJuridico;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr35Get() {
                
                #line 473 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                    dtClienteJuridico;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 470 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                                                                    dtClienteNatural;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr36Get() {
                
                #line 470 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                    dtClienteNatural;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 467 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                                                                    iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr37Get() {
                
                #line 467 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                    iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 355 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                          perfil == PerfilUsuario.Institucional;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr39Get() {
                
                #line 355 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                          perfil == PerfilUsuario.Institucional;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 413 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 413 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 410 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                                                                iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr41Get() {
                
                #line 410 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 370 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                                  dtOrdenante.Rows.Count > 1 && iu.Perfil != PerfilUsuario.Institucional && iu.Perfil != PerfilUsuario.Demo;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr42Get() {
                
                #line 370 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                  dtOrdenante.Rows.Count > 1 && iu.Perfil != PerfilUsuario.Institucional && iu.Perfil != PerfilUsuario.Demo;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 382 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.PerfilUsuario>> expression = () => 
                                                                                          PerfilUsuario.MultiOrdenante;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.PerfilUsuario @__Expr43Get() {
                
                #line 382 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                          PerfilUsuario.MultiOrdenante;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.PerfilUsuario ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 364 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                                                dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 364 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                dtOrdenante.Rows[0]["IdCliente"].ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 361 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                                                                iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr46Get() {
                
                #line 361 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                                iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 244 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr47Get() {
                
                #line 244 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                        IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                                            iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr48Get() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                            iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 255 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                          Business.IpAddress.IsValidLocalIpAddress(strIdUser,strIpAddress);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr49Get() {
                
                #line 255 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                          Business.IpAddress.IsValidLocalIpAddress(strIdUser,strIpAddress);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 276 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                                  EstadoAutenticacion.IpInvalidaParaPerfil;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr50Get() {
                
                #line 276 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                  EstadoAutenticacion.IpInvalidaParaPerfil;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 261 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                                                iu;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr52Get() {
                
                #line 261 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                                iu;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 206 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                        Business.Usuario.ValidatePassword(strPassword, (string)datos.Rows[0]["Hash"], (string)datos.Rows[0]["Salt"]);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr53Get() {
                
                #line 206 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                        Business.Usuario.ValidatePassword(strPassword, (string)datos.Rows[0]["Hash"], (string)datos.Rows[0]["Salt"]);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 515 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                                Business.Usuario.UpdateFailedAttempts(strIdUser, Convert.ToInt32(datos.Rows[0]["NumVecesErrado"]));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr54Get() {
                
                #line 515 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                                Business.Usuario.UpdateFailedAttempts(strIdUser, Convert.ToInt32(datos.Rows[0]["NumVecesErrado"]));
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                                            null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr56Get() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                            null;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.EstadoAutenticacion>> expression = () => 
                                        EstadoAutenticacion.UsuarioBloqueado;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion @__Expr58Get() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                                        EstadoAutenticacion.UsuarioBloqueado;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.EstadoAutenticacion ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    Business.Usuario.FillUserDavHb(strIdUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr60Get() {
                
                #line 124 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\AUTENTICATIONACTIVITY.XAML"
                return 
                    Business.Usuario.FillUserDavHb(strIdUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            protected override void GetValueTypeValues() {
                this.eu = ((Dataifx.Trading.CommonObjects.EstadoUsuario)(this.GetVariableValue((12 + locationsOffset))));
                this.perfil = ((Dataifx.Trading.CommonObjects.PerfilUsuario)(this.GetVariableValue((13 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 17))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 17);
                }
                expectedLocationsCount = 17;
                if (((locationReferences[(offset + 11)].Name != "datos") 
                            || (locationReferences[(offset + 11)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "dtOrdenante") 
                            || (locationReferences[(offset + 14)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "dtClienteJuridico") 
                            || (locationReferences[(offset + 15)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "dtClienteNatural") 
                            || (locationReferences[(offset + 16)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "eu") 
                            || (locationReferences[(offset + 12)].Type != typeof(Dataifx.Trading.CommonObjects.EstadoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "perfil") 
                            || (locationReferences[(offset + 13)].Type != typeof(Dataifx.Trading.CommonObjects.PerfilUsuario)))) {
                    return false;
                }
                return AutenticationActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
