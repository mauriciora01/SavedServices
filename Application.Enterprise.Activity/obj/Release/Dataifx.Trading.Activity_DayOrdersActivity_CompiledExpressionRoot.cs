namespace Dataifx.Trading.Activity {
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\DayOrdersActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class DayOrdersActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext1 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<System.Data.DataTable>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext2 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext4 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext5 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext6 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext7 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext8 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext9 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext11 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<System.Data.DataTable>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext12 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext13 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<System.Data.DataTable>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext14 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext15 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<System.Data.DataTable>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext16 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext17 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<System.Data.DataTable>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext18 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext19 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext20 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext21 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext21.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext22 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext23 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext24 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<System.Data.DataTable>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext25 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext26 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<System.Data.DataTable>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext27 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext28 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext29 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext30 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext30.GetLocation<System.Data.DataTable>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext31 = ((DayOrdersActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = DayOrdersActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new DayOrdersActivity_TypedDataContext2(locations, activityContext, true);
                }
                DayOrdersActivity_TypedDataContext2 refDataContext32 = ((DayOrdersActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext32.GetLocation<System.Data.DataTable>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
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
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext0 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                DayOrdersActivity_TypedDataContext2 refDataContext1 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<System.Data.DataTable>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext2 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext3 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                DayOrdersActivity_TypedDataContext2 refDataContext4 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.Data.DataTable>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext5 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                DayOrdersActivity_TypedDataContext2 refDataContext6 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext7 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                DayOrdersActivity_TypedDataContext2 refDataContext8 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext9 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext10 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                DayOrdersActivity_TypedDataContext2 refDataContext11 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<System.Data.DataTable>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext12 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                DayOrdersActivity_TypedDataContext2 refDataContext13 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<System.Data.DataTable>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext14 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                DayOrdersActivity_TypedDataContext2 refDataContext15 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<System.Data.DataTable>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext16 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                DayOrdersActivity_TypedDataContext2 refDataContext17 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<System.Data.DataTable>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext18 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                DayOrdersActivity_TypedDataContext2 refDataContext19 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext20 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                DayOrdersActivity_TypedDataContext2 refDataContext21 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext21.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext22 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext23 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                DayOrdersActivity_TypedDataContext2 refDataContext24 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<System.Data.DataTable>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext25 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                DayOrdersActivity_TypedDataContext2 refDataContext26 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<System.Data.DataTable>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext27 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                DayOrdersActivity_TypedDataContext2 refDataContext28 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext29 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                DayOrdersActivity_TypedDataContext2 refDataContext30 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext30.GetLocation<System.Data.DataTable>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                DayOrdersActivity_TypedDataContext2_ForReadOnly valDataContext31 = new DayOrdersActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                DayOrdersActivity_TypedDataContext2 refDataContext32 = new DayOrdersActivity_TypedDataContext2(locations, true);
                return refDataContext32.GetLocation<System.Data.DataTable>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Business.ParametroConfiguracion.Obtener(objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtParametrosConf") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtDayOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrdenesAbiertas)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerInformacionBasica(strIdClient)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Client") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "objUser.Perfil == PerfilUsuario.TraderSoporte") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, Client)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtDayOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasMultiOrdenante(objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ConsultarDiaMultiOrdenanteComercial(DateTime.Now,objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtDayOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasTrader(objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "strIdClient.Replace(\',\',\'.\')") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIdClient") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerInformacionBasica(strIdClient)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Client") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "objUser.Perfil == PerfilUsuario.TraderSoporte") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, \"\")") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtDayOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrd" +
                            "enesAbiertas, Client.InfoCliente.AplicaIVA)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, objUser.Id)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtDayOrders") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Orden.ObtenerCursadasTrader(objUser)") 
                        && (DayOrdersActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtOrdenesAbiertas") 
                        && (DayOrdersActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
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
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new DayOrdersActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new DayOrdersActivity_TypedDataContext2(locationReferences).@__Expr32GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DayOrdersActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DayOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class DayOrdersActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DayOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class DayOrdersActivity_TypedDataContext1 : DayOrdersActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public DayOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario objUser {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> MyOrders {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)(this.GetVariableValue((2 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "strIdClient") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "objUser") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "MyOrders") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return DayOrdersActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DayOrdersActivity_TypedDataContext1_ForReadOnly : DayOrdersActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public DayOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIdClient {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario objUser {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> MyOrders {
                get {
                    return ((System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)(this.GetVariableValue((2 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "strIdClient") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "objUser") 
                            || (locationReferences[(offset + 1)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "MyOrders") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "IdFirma") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return DayOrdersActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DayOrdersActivity_TypedDataContext2 : DayOrdersActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DayOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
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
            
            protected System.Data.DataTable dtDayOrders {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtOrdenesAbiertas {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
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
                
                #line 67 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
              dtParametrosConf;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr1Get() {
                
                #line 67 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
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
                
                #line 67 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
              dtParametrosConf = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 310 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    dtDayOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr4Get() {
                
                #line 310 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    dtDayOrders;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.Data.DataTable value) {
                
                #line 310 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                    dtDayOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 252 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                                    MyOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr6Get() {
                
                #line 252 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    MyOrders;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                
                #line 252 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                    MyOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 205 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Client;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr8Get() {
                
                #line 205 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    Client;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 205 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                    Client = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 272 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                            dtDayOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr11Get() {
                
                #line 272 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                            dtDayOrders;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(System.Data.DataTable value) {
                
                #line 272 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                            dtDayOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 286 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr13Get() {
                
                #line 286 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(System.Data.DataTable value) {
                
                #line 286 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 224 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                            dtDayOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr15Get() {
                
                #line 224 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                            dtDayOrders;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(System.Data.DataTable value) {
                
                #line 224 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                            dtDayOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 238 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr17Get() {
                
                #line 238 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(System.Data.DataTable value) {
                
                #line 238 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 85 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    strIdClient;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 85 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    strIdClient;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(string value) {
                
                #line 85 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                    strIdClient = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                        Client;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr21Get() {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                        Client;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 99 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                        Client = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 166 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtDayOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr24Get() {
                
                #line 166 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                dtDayOrders;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(System.Data.DataTable value) {
                
                #line 166 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                dtDayOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                    dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr26Get() {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(System.Data.DataTable value) {
                
                #line 180 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                    dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                                        MyOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr28Get() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                        MyOrders;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                        MyOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 118 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                dtDayOrders;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr30Get() {
                
                #line 118 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                dtDayOrders;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(System.Data.DataTable value) {
                
                #line 118 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                dtDayOrders = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                    dtOrdenesAbiertas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr32Get() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    dtOrdenesAbiertas;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(System.Data.DataTable value) {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                
                                    dtOrdenesAbiertas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
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
                if (((locationReferences[(offset + 4)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Client") 
                            || (locationReferences[(offset + 5)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "dtDayOrders") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "dtOrdenesAbiertas") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return DayOrdersActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class DayOrdersActivity_TypedDataContext2_ForReadOnly : DayOrdersActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public DayOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public DayOrdersActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Data.DataTable dtParametrosConf {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario Client {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtDayOrders {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtOrdenesAbiertas {
                get {
                    return ((System.Data.DataTable)(this.GetVariableValue((7 + locationsOffset))));
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
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
              Business.ParametroConfiguracion.Obtener(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr0Get() {
                
                #line 72 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
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
                
                #line 79 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 79 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
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
                
                #line 315 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                    Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr3Get() {
                
                #line 315 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 257 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                                    Business.Orden.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr5Get() {
                
                #line 257 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    Business.Orden.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrdenesAbiertas);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 210 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Business.Usuario.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr7Get() {
                
                #line 210 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    Business.Usuario.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 217 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 217 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 277 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                            Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, Client);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr10Get() {
                
                #line 277 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                            Business.Orden.ConsultarDiaMultiOrdenante(DateTime.Now, Client);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 291 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Orden.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr12Get() {
                
                #line 291 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                Business.Orden.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 229 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                            Business.Orden.ConsultarDiaMultiOrdenanteComercial(DateTime.Now,objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr14Get() {
                
                #line 229 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                            Business.Orden.ConsultarDiaMultiOrdenanteComercial(DateTime.Now,objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 243 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr16Get() {
                
                #line 243 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 90 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    strIdClient.Replace(',','.');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 90 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                    strIdClient.Replace(',','.');
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 104 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                        Business.Correval.User.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr20Get() {
                
                #line 104 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                        Business.Correval.User.ObtenerInformacionBasica(strIdClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 111 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 111 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                        objUser.Perfil == PerfilUsuario.TraderSoporte;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, "");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr23Get() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, "");
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                    Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr25Get() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    Business.Correval.OrderRouting.ObtenerCursadasMultiOrdenante(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order>>> expression = () => 
                                        Business.Correval.OrderRouting.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrdenesAbiertas, Client.InfoCliente.AplicaIVA);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> @__Expr27Get() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                        Business.Correval.OrderRouting.FillDayOrders(dtDayOrders, dtParametrosConf, dtOrdenesAbiertas, Client.InfoCliente.AplicaIVA);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Order> ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 123 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, objUser.Id);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr29Get() {
                
                #line 123 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                Business.Correval.OrderRouting.ConsultarDiaMultiOrdenante(Client, objUser.Id);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                    Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr31Get() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\DAYORDERSACTIVITY.XAML"
                return 
                                    Business.Orden.ObtenerCursadasTrader(objUser);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
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
                if (((locationReferences[(offset + 4)].Name != "dtParametrosConf") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Client") 
                            || (locationReferences[(offset + 5)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "dtDayOrders") 
                            || (locationReferences[(offset + 6)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "dtOrdenesAbiertas") 
                            || (locationReferences[(offset + 7)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                return DayOrdersActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
