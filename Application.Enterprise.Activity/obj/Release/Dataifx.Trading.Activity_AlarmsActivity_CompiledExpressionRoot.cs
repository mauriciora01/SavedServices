namespace Dataifx.Trading.Activity {
    
    #line 22 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\AlarmsActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class AlarmsActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = AlarmsActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext2 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext4 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext5 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext6 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext7 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext8 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext9 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext11 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext12 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext13 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<int>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext14 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext15 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext16 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext17 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext18 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext19 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext19.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext20 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext21 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext22 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext22.GetLocation<char>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext23 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext24 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<char>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext25 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext26 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext27 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext27.GetLocation<long>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext28 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext29 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext29.GetLocation<long>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext30 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext31 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<long>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext32 = ((AlarmsActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext33 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<char>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext34 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext34.GetLocation<char>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext35 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = AlarmsActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new AlarmsActivity_TypedDataContext2(locations, activityContext, true);
                }
                AlarmsActivity_TypedDataContext2 refDataContext36 = ((AlarmsActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set, expressionId, this.rootActivity, activityContext);
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
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext0 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext1 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                AlarmsActivity_TypedDataContext2 refDataContext2 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext3 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext4 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                AlarmsActivity_TypedDataContext2 refDataContext5 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext6 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                AlarmsActivity_TypedDataContext2 refDataContext7 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext8 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                AlarmsActivity_TypedDataContext2 refDataContext9 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<int>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext10 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                AlarmsActivity_TypedDataContext2 refDataContext11 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                AlarmsActivity_TypedDataContext2 refDataContext12 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<bool>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                AlarmsActivity_TypedDataContext2 refDataContext13 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<int>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext14 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                AlarmsActivity_TypedDataContext2 refDataContext15 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext16 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                AlarmsActivity_TypedDataContext2 refDataContext17 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<int>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext18 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                AlarmsActivity_TypedDataContext2 refDataContext19 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext19.GetLocation<Dataifx.Trading.Infrastructure.Models.Error>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                AlarmsActivity_TypedDataContext2 refDataContext20 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<bool>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext21 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                AlarmsActivity_TypedDataContext2 refDataContext22 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext22.GetLocation<char>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext23 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                AlarmsActivity_TypedDataContext2 refDataContext24 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<char>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext25 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext26 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                AlarmsActivity_TypedDataContext2 refDataContext27 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext27.GetLocation<long>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext28 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                AlarmsActivity_TypedDataContext2 refDataContext29 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext29.GetLocation<long>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext30 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                AlarmsActivity_TypedDataContext2 refDataContext31 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<long>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                AlarmsActivity_TypedDataContext2_ForReadOnly valDataContext32 = new AlarmsActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                AlarmsActivity_TypedDataContext2 refDataContext33 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<char>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                AlarmsActivity_TypedDataContext2 refDataContext34 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext34.GetLocation<char>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                AlarmsActivity_TypedDataContext2 refDataContext35 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                AlarmsActivity_TypedDataContext2 refDataContext36 = new AlarmsActivity_TypedDataContext2(locations, true);
                return refDataContext36.GetLocation<string>(refDataContext36.ValueType___Expr36Get, refDataContext36.ValueType___Expr36Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MayorOIgual") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MenorOIgual") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIndicador") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Order.Id == 0") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Data.Alarma.AdicionarCA(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id," +
                            " Convert.ToDecimal(Alarma.Value),\n                    strIndicador, lIdPreorden," +
                            " Alarma.OriginatorId);") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Id") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Error") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Error.existError") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Data.Alarma.Adicionar(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id, C" +
                            "onvert.ToDecimal(Alarma.Value),\n                    strIndicador, lIdPreorden, A" +
                            "larma.OriginatorId);") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdAlarm") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Id") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new Infrastructure.Models.Error()") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Error") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Alarma.Error.existError") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Order.BussinessType == Infrastructure.Enumerations.TransactionType.Buy") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strBussinessType") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Order.OrdeType.Id.ToString().Length > 0") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strOrderType") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Data.Orden.AdicionarAlarmaPreOrden(Alarma)") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lIdPreorden") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id, strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email , Alarma.Order.PercentageCommission.ToString() , Alarma.Order.Justification)") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lIdPreorden") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id.Replace(',','.'), strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email, Alarma.OriginatorId);") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lIdPreorden") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Alarma.Order.OrdeType.Id") 
                        && (AlarmsActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strOrderType") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strBussinessType") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIndicador") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIndicador") 
                        && (AlarmsActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
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
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new AlarmsActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new AlarmsActivity_TypedDataContext2(locationReferences).@__Expr36GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AlarmsActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AlarmsActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class AlarmsActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public AlarmsActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class AlarmsActivity_TypedDataContext1 : AlarmsActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected long lIdPreorden;
            
            protected int IdFirma;
            
            public AlarmsActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Alarm Alarma {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Alarm)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
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
                this.lIdPreorden = ((long)(this.GetVariableValue((1 + locationsOffset))));
                this.IdFirma = ((int)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.lIdPreorden);
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
                if (((locationReferences[(offset + 0)].Name != "Alarma") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Alarm)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "lIdPreorden") 
                            || (locationReferences[(offset + 1)].Type != typeof(long)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return AlarmsActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AlarmsActivity_TypedDataContext1_ForReadOnly : AlarmsActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected long lIdPreorden;
            
            protected int IdFirma;
            
            public AlarmsActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Alarm Alarma {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Alarm)(this.GetVariableValue((0 + locationsOffset))));
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
                this.lIdPreorden = ((long)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "Alarma") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Alarm)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "lIdPreorden") 
                            || (locationReferences[(offset + 1)].Type != typeof(long)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return AlarmsActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AlarmsActivity_TypedDataContext2 : AlarmsActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected char strBussinessType;
            
            protected char strOrderType;
            
            protected int IdAlarm;
            
            public AlarmsActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIndicador {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
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
                
                #line 415 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      strIndicador;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 415 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                      strIndicador;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(string value) {
                
                #line 415 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                      strIndicador = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 256 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 256 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 256 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                IdAlarm = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 268 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 268 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                    IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(int value) {
                
                #line 268 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                    IdAlarm = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 283 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        Alarma.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr9Get() {
                
                #line 283 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                        Alarma.Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(int value) {
                
                #line 283 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                        Alarma.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 297 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            Alarma.Error;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr11Get() {
                
                #line 297 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                            Alarma.Error;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 297 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                            Alarma.Error = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 311 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                Alarma.Error.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 311 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                                Alarma.Error.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(bool value) {
                
                #line 311 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                                Alarma.Error.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 144 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr13Get() {
                
                #line 144 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(int value) {
                
                #line 144 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                IdAlarm = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                    IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(int value) {
                
                #line 156 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                    IdAlarm = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        Alarma.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr17Get() {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                        Alarma.Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(int value) {
                
                #line 171 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                        Alarma.Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            Alarma.Error;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr19Get() {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                            Alarma.Error;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                
                #line 185 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                            Alarma.Error = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(Dataifx.Trading.Infrastructure.Models.Error value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                                Alarma.Error.existError;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                                Alarma.Error.existError;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(bool value) {
                
                #line 199 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                                                Alarma.Error.existError = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 359 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<char>> expression = () => 
                              strBussinessType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public char @__Expr22Get() {
                
                #line 359 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                              strBussinessType;
                
                #line default
                #line hidden
            }
            
            public char ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(char value) {
                
                #line 359 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                              strBussinessType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(char value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<char>> expression = () => 
                                      strOrderType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public char @__Expr24Get() {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                      strOrderType;
                
                #line default
                #line hidden
            }
            
            public char ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(char value) {
                
                #line 338 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                      strOrderType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(char value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 242 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            lIdPreorden;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr27Get() {
                
                #line 242 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            lIdPreorden;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(long value) {
                
                #line 242 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                            lIdPreorden = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 127 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            lIdPreorden;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr29Get() {
                
                #line 127 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            lIdPreorden;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(long value) {
                
                #line 127 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                            lIdPreorden = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 221 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            lIdPreorden;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr31Get() {
                
                #line 221 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            lIdPreorden;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(long value) {
                
                #line 221 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                            lIdPreorden = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 109 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<char>> expression = () => 
                                      strOrderType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public char @__Expr33Get() {
                
                #line 109 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                      strOrderType;
                
                #line default
                #line hidden
            }
            
            public char ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(char value) {
                
                #line 109 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                                      strOrderType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(char value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<char>> expression = () => 
                              strBussinessType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public char @__Expr34Get() {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                              strBussinessType;
                
                #line default
                #line hidden
            }
            
            public char ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(char value) {
                
                #line 92 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                              strBussinessType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(char value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 398 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      strIndicador;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 398 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                      strIndicador;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(string value) {
                
                #line 398 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                      strIndicador = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 70 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  strIndicador;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 70 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                  strIndicador;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr36Set(string value) {
                
                #line 70 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                
                  strIndicador = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr36Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr36Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.strBussinessType = ((char)(this.GetVariableValue((4 + locationsOffset))));
                this.strOrderType = ((char)(this.GetVariableValue((5 + locationsOffset))));
                this.IdAlarm = ((int)(this.GetVariableValue((6 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.strBussinessType);
                this.SetVariableValue((5 + locationsOffset), this.strOrderType);
                this.SetVariableValue((6 + locationsOffset), this.IdAlarm);
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
                if (((locationReferences[(offset + 3)].Name != "strIndicador") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "strBussinessType") 
                            || (locationReferences[(offset + 4)].Type != typeof(char)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "strOrderType") 
                            || (locationReferences[(offset + 5)].Type != typeof(char)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IdAlarm") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return AlarmsActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class AlarmsActivity_TypedDataContext2_ForReadOnly : AlarmsActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected char strBussinessType;
            
            protected char strOrderType;
            
            protected int IdAlarm;
            
            public AlarmsActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public AlarmsActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string strIndicador {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
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
                
                #line 63 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MayorOIgual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr0Get() {
                
                #line 63 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
          Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MayorOIgual;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MenorOIgual;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 391 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
              Alarma.Indicator == Infrastructure.Enumerations.IndicatorAlarmcs.MenorOIgual;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  Alarma.Order.Id == 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr3Get() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                  Alarma.Order.Id == 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 376 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 376 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                      IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 273 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    Data.Alarma.AdicionarCA(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id, Convert.ToDecimal(Alarma.Value),
                    strIndicador, lIdPreorden, Alarma.OriginatorId);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 273 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                    Data.Alarma.AdicionarCA(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id, Convert.ToDecimal(Alarma.Value),
                    strIndicador, lIdPreorden, Alarma.OriginatorId);;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 288 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr8Get() {
                
                #line 288 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                        IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 302 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr10Get() {
                
                #line 302 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                    Data.Alarma.Adicionar(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id, Convert.ToDecimal(Alarma.Value),
                    strIndicador, lIdPreorden, Alarma.OriginatorId);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr14Get() {
                
                #line 161 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                    Data.Alarma.Adicionar(Alarma.Order.Instrument.mnemonic, Alarma.Order.Client.Id, Convert.ToDecimal(Alarma.Value),
                    strIndicador, lIdPreorden, Alarma.OriginatorId);;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                                        IdAlarm;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr16Get() {
                
                #line 176 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                        IdAlarm;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Error>> expression = () => 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Error @__Expr18Get() {
                
                #line 190 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                                            new Infrastructure.Models.Error();
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Error ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 85 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Alarma.Order.BussinessType == Infrastructure.Enumerations.TransactionType.Buy;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 85 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                      Alarma.Order.BussinessType == Infrastructure.Enumerations.TransactionType.Buy;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 102 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Alarma.Order.OrdeType.Id.ToString().Length > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 102 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                              Alarma.Order.OrdeType.Id.ToString().Length > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 121 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr25Get() {
                
                #line 121 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                      IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 247 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            Data.Orden.AdicionarAlarmaPreOrden(Alarma);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr26Get() {
                
                #line 247 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            Data.Orden.AdicionarAlarmaPreOrden(Alarma);
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id, strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email , Alarma.Order.PercentageCommission.ToString() , Alarma.Order.Justification);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr28Get() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id, strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email , Alarma.Order.PercentageCommission.ToString() , Alarma.Order.Justification);
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 226 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                                            Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id.Replace(',','.'), strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email, Alarma.OriginatorId);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr30Get() {
                
                #line 226 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                            Data.Orden.AdicionarAlarma(Alarma.Order.Instrument.mnemonic,
                        Alarma.Order.Client.Id.Replace(',','.'), strOrderType, strBussinessType,
                        Alarma.Order.Quantity, Convert.ToDecimal(Alarma.Order.Value), Alarma.Order.EffectiveDate,
                        DateTime.Now, Alarma.Order.DecevalAccount.AccountNumber, Alarma.Email, Alarma.OriginatorId);;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<char>> expression = () => 
                                      Alarma.Order.OrdeType.Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public char @__Expr32Get() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\ALARMSACTIVITY.XAML"
                return 
                                      Alarma.Order.OrdeType.Id;
                
                #line default
                #line hidden
            }
            
            public char ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            protected override void GetValueTypeValues() {
                this.strBussinessType = ((char)(this.GetVariableValue((4 + locationsOffset))));
                this.strOrderType = ((char)(this.GetVariableValue((5 + locationsOffset))));
                this.IdAlarm = ((int)(this.GetVariableValue((6 + locationsOffset))));
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
                if (((locationReferences[(offset + 3)].Name != "strIndicador") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "strBussinessType") 
                            || (locationReferences[(offset + 4)].Type != typeof(char)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "strOrderType") 
                            || (locationReferences[(offset + 5)].Type != typeof(char)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IdAlarm") 
                            || (locationReferences[(offset + 6)].Type != typeof(int)))) {
                    return false;
                }
                return AlarmsActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
