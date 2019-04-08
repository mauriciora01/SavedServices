namespace Dataifx.Trading.Activity {
    
    #line 25 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 26 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 27 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 28 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 29 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 30 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using Dataifx.Trading.CommonObjects;
    
    #line default
    #line hidden
    
    #line 31 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using Dataifx.Trading.Infrastructure.Models;
    
    #line default
    #line hidden
    
    #line 1 "C:\TFS\TradingSolution\Dataifx.Trading.Activity\InfoClientActivity.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class InfoClientActivity : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = InfoClientActivity_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext0 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext1 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext2 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext3 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext4 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext5 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext6 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext7 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<Dataifx.Trading.Infrastructure.Models.Account>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext8 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext9 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext10 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext11 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext12 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext13 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext14 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext15 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext16 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext17 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext18 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext19 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext20 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext20.GetLocation<Dataifx.Trading.Infrastructure.Models.Account>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext21 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext22 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext22.GetLocation<string>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext23 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext24 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext24.GetLocation<decimal>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext25 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext26 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext26.GetLocation<decimal>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext27 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext28 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext28.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext29 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext30 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext31 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext31.GetLocation<decimal>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext32 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext33 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext33.GetLocation<decimal>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext34 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext35 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext35.GetLocation<decimal>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext36 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext37 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext37.GetLocation<decimal>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext38 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext39 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext39.GetLocation<decimal>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext40 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext41 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext41.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext42 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext43 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext44 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext45 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext45.GetLocation<decimal>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext46 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext47 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext47.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext48 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext49 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext49.GetLocation<string>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext50 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext51 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext51.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext52 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext53 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext54 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext54.GetLocation<decimal>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext55 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext56 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext56.GetLocation<decimal>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 57)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext57 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext58 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext58.GetLocation<decimal>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 59)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext59 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext60 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext60.GetLocation<decimal>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 61)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext61 = ((InfoClientActivity_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = InfoClientActivity_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new InfoClientActivity_TypedDataContext2(locations, activityContext, true);
                }
                InfoClientActivity_TypedDataContext2 refDataContext62 = ((InfoClientActivity_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext62.GetLocation<decimal>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set, expressionId, this.rootActivity, activityContext);
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
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext0 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext1 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext2 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext3 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext4 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                InfoClientActivity_TypedDataContext2 refDataContext5 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext6 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                InfoClientActivity_TypedDataContext2 refDataContext7 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<Dataifx.Trading.Infrastructure.Models.Account>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext8 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                InfoClientActivity_TypedDataContext2 refDataContext9 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<double>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext10 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext11 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                InfoClientActivity_TypedDataContext2 refDataContext12 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext13 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                InfoClientActivity_TypedDataContext2 refDataContext14 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext15 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                InfoClientActivity_TypedDataContext2 refDataContext16 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext16.GetLocation<System.Data.DataTable>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext17 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                InfoClientActivity_TypedDataContext2 refDataContext18 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<double>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext19 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                InfoClientActivity_TypedDataContext2 refDataContext20 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<Dataifx.Trading.Infrastructure.Models.Account>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext21 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                InfoClientActivity_TypedDataContext2 refDataContext22 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext22.GetLocation<string>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext23 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                InfoClientActivity_TypedDataContext2 refDataContext24 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext24.GetLocation<decimal>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext25 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                InfoClientActivity_TypedDataContext2 refDataContext26 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext26.GetLocation<decimal>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext27 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                InfoClientActivity_TypedDataContext2 refDataContext28 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext28.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person>>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext29 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext30 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                InfoClientActivity_TypedDataContext2 refDataContext31 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext31.GetLocation<decimal>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext32 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                InfoClientActivity_TypedDataContext2 refDataContext33 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext33.GetLocation<decimal>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext34 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                InfoClientActivity_TypedDataContext2 refDataContext35 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext35.GetLocation<decimal>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext36 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                InfoClientActivity_TypedDataContext2 refDataContext37 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext37.GetLocation<decimal>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext38 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                InfoClientActivity_TypedDataContext2 refDataContext39 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext39.GetLocation<decimal>(refDataContext39.ValueType___Expr39Get, refDataContext39.ValueType___Expr39Set);
            }
            if ((expressionId == 40)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext40 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                InfoClientActivity_TypedDataContext2 refDataContext41 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext41.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext42 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            if ((expressionId == 43)) {
                InfoClientActivity_TypedDataContext2 refDataContext43 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext44 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                InfoClientActivity_TypedDataContext2 refDataContext45 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<decimal>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext46 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                InfoClientActivity_TypedDataContext2 refDataContext47 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext47.GetLocation<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext48 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                InfoClientActivity_TypedDataContext2 refDataContext49 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext49.GetLocation<string>(refDataContext49.ValueType___Expr49Get, refDataContext49.ValueType___Expr49Set);
            }
            if ((expressionId == 50)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext50 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                InfoClientActivity_TypedDataContext2 refDataContext51 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext51.GetLocation<Dataifx.Trading.CommonObjects.InfoUsuario>(refDataContext51.ValueType___Expr51Get, refDataContext51.ValueType___Expr51Set);
            }
            if ((expressionId == 52)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext52 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext53 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext53.ValueType___Expr53Get();
            }
            if ((expressionId == 54)) {
                InfoClientActivity_TypedDataContext2 refDataContext54 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext54.GetLocation<decimal>(refDataContext54.ValueType___Expr54Get, refDataContext54.ValueType___Expr54Set);
            }
            if ((expressionId == 55)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext55 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            if ((expressionId == 56)) {
                InfoClientActivity_TypedDataContext2 refDataContext56 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext56.GetLocation<decimal>(refDataContext56.ValueType___Expr56Get, refDataContext56.ValueType___Expr56Set);
            }
            if ((expressionId == 57)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext57 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext57.ValueType___Expr57Get();
            }
            if ((expressionId == 58)) {
                InfoClientActivity_TypedDataContext2 refDataContext58 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext58.GetLocation<decimal>(refDataContext58.ValueType___Expr58Get, refDataContext58.ValueType___Expr58Set);
            }
            if ((expressionId == 59)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext59 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext59.ValueType___Expr59Get();
            }
            if ((expressionId == 60)) {
                InfoClientActivity_TypedDataContext2 refDataContext60 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext60.GetLocation<decimal>(refDataContext60.ValueType___Expr60Get, refDataContext60.ValueType___Expr60Set);
            }
            if ((expressionId == 61)) {
                InfoClientActivity_TypedDataContext2_ForReadOnly valDataContext61 = new InfoClientActivity_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext61.ValueType___Expr61Get();
            }
            if ((expressionId == 62)) {
                InfoClientActivity_TypedDataContext2 refDataContext62 = new InfoClientActivity_TypedDataContext2(locations, true);
                return refDataContext62.GetLocation<decimal>(refDataContext62.ValueType___Expr62Get, refDataContext62.ValueType___Expr62Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.ObtenerInformacionPorWinsiob(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "infoUsuario") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.FillMyAccount(infoUsuario,AccountClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToDouble(AccountClient.Balance )") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.Balance") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IdFirma") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.GetSegmentsCommission(infoUsuario, infoUsuario.InfoCliente.Clasi" +
                            "ficacionFija, infoUsuario.InfoCliente.ClasificacionVariable)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.Segment") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Instrumento.ConsultarTipoMercadoPorCliente(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.ListMarketType") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.ConsultarSaldosNetosPorId(infoUsuario.Id, strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dtSaldosNetos") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToDouble(dtSaldosNetos.Rows[0][\"inventarios\"])") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.BalancePortfolio") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AccountClient") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.Account") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "infoUsuario.InfoCliente.CuentaDerivados") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.NumberAccountDerivados") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IngGarantiasConsumidas") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.ConsumedGuarantee") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "lngGarantiasConstituidas") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.ConstitutedGuarantee") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Cliente.ConsultarOrdenentesClientes(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.ListPayers") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "infoUsuario.InfoCliente.CuentaDerivados.Length > 0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.BuyingFuturesPower") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.CalculatePyGFutures(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.FuturesPYG") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.CalculatePreventiveRetention(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.PreventiveRetention") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.CalculateBuyingPower(MyClientInfo, lngSaldoFuturos)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.BuyingFuturesPower") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "AccountClient.BuyingFuturesPower - AccountClient.PreventiveRetention") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.BuyingFuturesPower") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Usuario.GetSegmentsCommission(infoUsuario)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.Segment") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ConsultarIdOrion(Convert.ToDecimal(strIdClient))") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.MyAccount") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerSaldoParaRetiros(Convert.ToDecimal(strIdClient))") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "AccountClient.Available") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Instrumento.ConsultarTipoMercadoPorCliente(Convert.ToDecimal(strIdClient" +
                            "))") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "MyClientInfo.ListMarketType") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "strIdClient.Replace(\',\',\'.\')") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "strIdClient") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerInformacionPorCliente(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "infoUsuario") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "infoUsuario.InfoCliente.CuentaDerivados.Length > 0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lngGarantiasConstituidas") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IngGarantiasConsumidas") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 56;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerGarantiasConsumidas(strIdClient,infoUsuario.InfoCli" +
                            "ente.CuentaDerivados)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 57;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IngGarantiasConsumidas") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 58;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ObtenerGarantiasConstituidas(strIdClient, infoUsuario.Info" +
                            "Cliente.CuentaDerivados)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 59;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lngGarantiasConstituidas") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 60;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Business.Correval.User.ConsultarCuentaClienteFuturos(strIdClient)") 
                        && (InfoClientActivity_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 61;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "lngSaldoFuturos") 
                        && (InfoClientActivity_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 62;
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
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            if ((expressionId == 56)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr56GetTree();
            }
            if ((expressionId == 57)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr57GetTree();
            }
            if ((expressionId == 58)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr58GetTree();
            }
            if ((expressionId == 59)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr59GetTree();
            }
            if ((expressionId == 60)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr60GetTree();
            }
            if ((expressionId == 61)) {
                return new InfoClientActivity_TypedDataContext2_ForReadOnly(locationReferences).@__Expr61GetTree();
            }
            if ((expressionId == 62)) {
                return new InfoClientActivity_TypedDataContext2(locationReferences).@__Expr62GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class InfoClientActivity_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public InfoClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class InfoClientActivity_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public InfoClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class InfoClientActivity_TypedDataContext1 : InfoClientActivity_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public InfoClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Client MyClientInfo {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Client)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string strIdClient {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "MyClientInfo") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Client)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strIdClient") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return InfoClientActivity_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class InfoClientActivity_TypedDataContext1_ForReadOnly : InfoClientActivity_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int IdFirma;
            
            public InfoClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Client MyClientInfo {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Client)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string strIdClient {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
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
                if (((locationReferences[(offset + 0)].Name != "MyClientInfo") 
                            || (locationReferences[(offset + 0)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Client)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "strIdClient") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "IdFirma") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                return InfoClientActivity_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class InfoClientActivity_TypedDataContext2 : InfoClientActivity_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected decimal IngGarantiasConsumidas;
            
            protected decimal lngGarantiasConstituidas;
            
            protected decimal lngSaldoFuturos;
            
            public InfoClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario infoUsuario {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Account AccountClient {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Account)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected System.Data.DataTable dtSaldosNetos {
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
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                infoUsuario;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr5Get() {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                infoUsuario;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 86 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                infoUsuario = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Account>> expression = () => 
                    AccountClient;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Account @__Expr7Get() {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                    AccountClient;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Account ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(Dataifx.Trading.Infrastructure.Models.Account value) {
                
                #line 100 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                    AccountClient = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(Dataifx.Trading.Infrastructure.Models.Account value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        AccountClient.Balance;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr9Get() {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                        AccountClient.Balance;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(double value) {
                
                #line 114 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                        AccountClient.Balance = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>> expression = () => 
                              MyClientInfo.Segment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> @__Expr12Get() {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                              MyClientInfo.Segment;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> value) {
                
                #line 132 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                              MyClientInfo.Segment = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                  MyClientInfo.ListMarketType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr14Get() {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                  MyClientInfo.ListMarketType;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                
                #line 146 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                  MyClientInfo.ListMarketType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 160 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                      dtSaldosNetos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr16Get() {
                
                #line 160 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                      dtSaldosNetos;
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(System.Data.DataTable value) {
                
                #line 160 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                      dtSaldosNetos = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(System.Data.DataTable value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 174 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          AccountClient.BalancePortfolio;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr18Get() {
                
                #line 174 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                          AccountClient.BalancePortfolio;
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(double value) {
                
                #line 174 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                          AccountClient.BalancePortfolio = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(double value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 188 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Account>> expression = () => 
                                              MyClientInfo.Account;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Account @__Expr20Get() {
                
                #line 188 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                              MyClientInfo.Account;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Account ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(Dataifx.Trading.Infrastructure.Models.Account value) {
                
                #line 188 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                              MyClientInfo.Account = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(Dataifx.Trading.Infrastructure.Models.Account value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 202 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  MyClientInfo.NumberAccountDerivados;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 202 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                  MyClientInfo.NumberAccountDerivados;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(string value) {
                
                #line 202 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                  MyClientInfo.NumberAccountDerivados = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 216 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                      AccountClient.ConsumedGuarantee;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr24Get() {
                
                #line 216 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                      AccountClient.ConsumedGuarantee;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(decimal value) {
                
                #line 216 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                      AccountClient.ConsumedGuarantee = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 230 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                          AccountClient.ConstitutedGuarantee;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr26Get() {
                
                #line 230 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                          AccountClient.ConstitutedGuarantee;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(decimal value) {
                
                #line 230 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                          AccountClient.ConstitutedGuarantee = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 244 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person>>> expression = () => 
                                                              MyClientInfo.ListPayers;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> @__Expr28Get() {
                
                #line 244 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                              MyClientInfo.ListPayers;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> value) {
                
                #line 244 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                              MyClientInfo.ListPayers = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 327 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                      AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr31Get() {
                
                #line 327 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                      AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(decimal value) {
                
                #line 327 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                                      AccountClient.BuyingFuturesPower = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 263 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                      AccountClient.FuturesPYG;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr33Get() {
                
                #line 263 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                      AccountClient.FuturesPYG;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(decimal value) {
                
                #line 263 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                                      AccountClient.FuturesPYG = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 277 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                          AccountClient.PreventiveRetention;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr35Get() {
                
                #line 277 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                          AccountClient.PreventiveRetention;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(decimal value) {
                
                #line 277 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                                          AccountClient.PreventiveRetention = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 291 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                              AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr37Get() {
                
                #line 291 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                              AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(decimal value) {
                
                #line 291 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                                              AccountClient.BuyingFuturesPower = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 305 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                                  AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr39Get() {
                
                #line 305 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                                  AccountClient.BuyingFuturesPower;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr39Set(decimal value) {
                
                #line 305 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                                                                  AccountClient.BuyingFuturesPower = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr39Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr39Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 361 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>> expression = () => 
                              MyClientInfo.Segment;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> @__Expr41Get() {
                
                #line 361 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                              MyClientInfo.Segment;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> value) {
                
                #line 361 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                              MyClientInfo.Segment = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 375 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  AccountClient.MyAccount;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 375 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                  AccountClient.MyAccount;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(string value) {
                
                #line 375 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                  AccountClient.MyAccount = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 389 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                      AccountClient.Available;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr45Get() {
                
                #line 389 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                      AccountClient.Available;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(decimal value) {
                
                #line 389 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                      AccountClient.Available = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 403 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                          MyClientInfo.ListMarketType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr47Get() {
                
                #line 403 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                          MyClientInfo.ListMarketType;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                
                #line 403 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                          MyClientInfo.ListMarketType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                strIdClient;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr49Get() {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                strIdClient;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr49Set(string value) {
                
                #line 435 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                strIdClient = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr49Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr49Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 449 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    infoUsuario;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr51Get() {
                
                #line 449 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                    infoUsuario;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr51Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                
                #line 449 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                    infoUsuario = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr51Set(Dataifx.Trading.CommonObjects.InfoUsuario value) {
                this.GetValueTypeValues();
                this.@__Expr51Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 519 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                            lngGarantiasConstituidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr54Get() {
                
                #line 519 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                            lngGarantiasConstituidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr54Set(decimal value) {
                
                #line 519 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                            lngGarantiasConstituidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr54Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr54Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr56GetTree() {
                
                #line 533 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                IngGarantiasConsumidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr56Get() {
                
                #line 533 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                IngGarantiasConsumidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr56Get() {
                this.GetValueTypeValues();
                return this.@__Expr56Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr56Set(decimal value) {
                
                #line 533 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                IngGarantiasConsumidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr56Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr56Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr58GetTree() {
                
                #line 468 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                            IngGarantiasConsumidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr58Get() {
                
                #line 468 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                            IngGarantiasConsumidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr58Get() {
                this.GetValueTypeValues();
                return this.@__Expr58Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr58Set(decimal value) {
                
                #line 468 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                            IngGarantiasConsumidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr58Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr58Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr60GetTree() {
                
                #line 482 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                lngGarantiasConstituidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr60Get() {
                
                #line 482 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                lngGarantiasConstituidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr60Get() {
                this.GetValueTypeValues();
                return this.@__Expr60Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr60Set(decimal value) {
                
                #line 482 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                lngGarantiasConstituidas = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr60Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr60Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr62GetTree() {
                
                #line 496 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                    lngSaldoFuturos;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr62Get() {
                
                #line 496 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                    lngSaldoFuturos;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr62Get() {
                this.GetValueTypeValues();
                return this.@__Expr62Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr62Set(decimal value) {
                
                #line 496 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                
                                    lngSaldoFuturos = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr62Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr62Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.IngGarantiasConsumidas = ((decimal)(this.GetVariableValue((6 + locationsOffset))));
                this.lngGarantiasConstituidas = ((decimal)(this.GetVariableValue((7 + locationsOffset))));
                this.lngSaldoFuturos = ((decimal)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this.IngGarantiasConsumidas);
                this.SetVariableValue((7 + locationsOffset), this.lngGarantiasConstituidas);
                this.SetVariableValue((8 + locationsOffset), this.lngSaldoFuturos);
                base.SetValueTypeValues();
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
                if (((locationReferences[(offset + 3)].Name != "infoUsuario") 
                            || (locationReferences[(offset + 3)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "AccountClient") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Account)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtSaldosNetos") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IngGarantiasConsumidas") 
                            || (locationReferences[(offset + 6)].Type != typeof(decimal)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "lngGarantiasConstituidas") 
                            || (locationReferences[(offset + 7)].Type != typeof(decimal)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "lngSaldoFuturos") 
                            || (locationReferences[(offset + 8)].Type != typeof(decimal)))) {
                    return false;
                }
                return InfoClientActivity_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class InfoClientActivity_TypedDataContext2_ForReadOnly : InfoClientActivity_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected decimal IngGarantiasConsumidas;
            
            protected decimal lngGarantiasConstituidas;
            
            protected decimal lngSaldoFuturos;
            
            public InfoClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public InfoClientActivity_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Dataifx.Trading.CommonObjects.InfoUsuario infoUsuario {
                get {
                    return ((Dataifx.Trading.CommonObjects.InfoUsuario)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected Dataifx.Trading.Infrastructure.Models.Account AccountClient {
                get {
                    return ((Dataifx.Trading.Infrastructure.Models.Account)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected System.Data.DataTable dtSaldosNetos {
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
                
                #line 63 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr0Get() {
                
                #line 63 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
          0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 68 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr1Get() {
                
                #line 68 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
          0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 73 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
          0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr2Get() {
                
                #line 73 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
          0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 80 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
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
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                Business.Usuario.ObtenerInformacionPorWinsiob(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr4Get() {
                
                #line 91 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                Business.Usuario.ObtenerInformacionPorWinsiob(strIdClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Account>> expression = () => 
                    Business.Usuario.FillMyAccount(infoUsuario,AccountClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Account @__Expr6Get() {
                
                #line 105 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                    Business.Usuario.FillMyAccount(infoUsuario,AccountClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Account ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                        Convert.ToDouble(AccountClient.Balance );
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr8Get() {
                
                #line 119 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                        Convert.ToDouble(AccountClient.Balance );
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        IdFirma;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr10Get() {
                
                #line 126 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                        IdFirma;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>> expression = () => 
                              Business.Usuario.GetSegmentsCommission(infoUsuario, infoUsuario.InfoCliente.ClasificacionFija, infoUsuario.InfoCliente.ClasificacionVariable);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> @__Expr11Get() {
                
                #line 137 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                              Business.Usuario.GetSegmentsCommission(infoUsuario, infoUsuario.InfoCliente.ClasificacionFija, infoUsuario.InfoCliente.ClasificacionVariable);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                  Business.Instrumento.ConsultarTipoMercadoPorCliente(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr13Get() {
                
                #line 151 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                  Business.Instrumento.ConsultarTipoMercadoPorCliente(strIdClient);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 165 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Data.DataTable>> expression = () => 
                                      Business.Cliente.ConsultarSaldosNetosPorId(infoUsuario.Id, strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Data.DataTable @__Expr15Get() {
                
                #line 165 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                      Business.Cliente.ConsultarSaldosNetosPorId(infoUsuario.Id, strIdClient);
                
                #line default
                #line hidden
            }
            
            public System.Data.DataTable ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 179 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<double>> expression = () => 
                                          Convert.ToDouble(dtSaldosNetos.Rows[0]["inventarios"]);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public double @__Expr17Get() {
                
                #line 179 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                          Convert.ToDouble(dtSaldosNetos.Rows[0]["inventarios"]);
                
                #line default
                #line hidden
            }
            
            public double ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 193 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.Infrastructure.Models.Account>> expression = () => 
                                              AccountClient;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.Infrastructure.Models.Account @__Expr19Get() {
                
                #line 193 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                              AccountClient;
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.Infrastructure.Models.Account ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 207 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  infoUsuario.InfoCliente.CuentaDerivados;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 207 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                  infoUsuario.InfoCliente.CuentaDerivados;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 221 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                      IngGarantiasConsumidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr23Get() {
                
                #line 221 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                      IngGarantiasConsumidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 235 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                          lngGarantiasConstituidas;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr25Get() {
                
                #line 235 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                          lngGarantiasConstituidas;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person>>> expression = () => 
                                                              Business.Cliente.ConsultarOrdenentesClientes(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> @__Expr27Get() {
                
                #line 249 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                              Business.Cliente.ConsultarOrdenentesClientes(strIdClient);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Person> ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 256 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                              infoUsuario.InfoCliente.CuentaDerivados.Length > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 256 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                              infoUsuario.InfoCliente.CuentaDerivados.Length > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 332 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                      0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr30Get() {
                
                #line 332 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                      0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 268 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                      Business.Correval.User.CalculatePyGFutures(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr32Get() {
                
                #line 268 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                      Business.Correval.User.CalculatePyGFutures(strIdClient);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 282 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                          Business.Correval.User.CalculatePreventiveRetention(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr34Get() {
                
                #line 282 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                          Business.Correval.User.CalculatePreventiveRetention(strIdClient);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 296 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                              Business.Correval.User.CalculateBuyingPower(MyClientInfo, lngSaldoFuturos);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr36Get() {
                
                #line 296 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                              Business.Correval.User.CalculateBuyingPower(MyClientInfo, lngSaldoFuturos);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 310 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                                                                  AccountClient.BuyingFuturesPower - AccountClient.PreventiveRetention;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr38Get() {
                
                #line 310 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                                                                  AccountClient.BuyingFuturesPower - AccountClient.PreventiveRetention;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 366 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment>>> expression = () => 
                              Business.Usuario.GetSegmentsCommission(infoUsuario);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> @__Expr40Get() {
                
                #line 366 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                              Business.Usuario.GetSegmentsCommission(infoUsuario);
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Models.Segment> ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 380 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Business.Correval.User.ConsultarIdOrion(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr42Get() {
                
                #line 380 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                  Business.Correval.User.ConsultarIdOrion(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 394 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                      Business.Correval.User.ObtenerSaldoParaRetiros(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr44Get() {
                
                #line 394 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                      Business.Correval.User.ObtenerSaldoParaRetiros(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 408 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType>>> expression = () => 
                                          Business.Instrumento.ConsultarTipoMercadoPorCliente(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> @__Expr46Get() {
                
                #line 408 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                          Business.Instrumento.ConsultarTipoMercadoPorCliente(Convert.ToDecimal(strIdClient));
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<Dataifx.Trading.Infrastructure.Enumerations.MarketType> ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 440 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                strIdClient.Replace(',','.');
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr48Get() {
                
                #line 440 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                strIdClient.Replace(',','.');
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 454 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<Dataifx.Trading.CommonObjects.InfoUsuario>> expression = () => 
                    Business.Correval.User.ObtenerInformacionPorCliente(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Dataifx.Trading.CommonObjects.InfoUsuario @__Expr50Get() {
                
                #line 454 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                    Business.Correval.User.ObtenerInformacionPorCliente(strIdClient);
                
                #line default
                #line hidden
            }
            
            public Dataifx.Trading.CommonObjects.InfoUsuario ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 461 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    infoUsuario.InfoCliente.CuentaDerivados.Length > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr52Get() {
                
                #line 461 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                    infoUsuario.InfoCliente.CuentaDerivados.Length > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 524 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                            0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr53Get() {
                
                #line 524 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                            0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 538 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr55Get() {
                
                #line 538 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                0;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr57GetTree() {
                
                #line 473 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                            Business.Correval.User.ObtenerGarantiasConsumidas(strIdClient,infoUsuario.InfoCliente.CuentaDerivados);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr57Get() {
                
                #line 473 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                            Business.Correval.User.ObtenerGarantiasConsumidas(strIdClient,infoUsuario.InfoCliente.CuentaDerivados);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr57Get() {
                this.GetValueTypeValues();
                return this.@__Expr57Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr59GetTree() {
                
                #line 487 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                Business.Correval.User.ObtenerGarantiasConstituidas(strIdClient, infoUsuario.InfoCliente.CuentaDerivados);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr59Get() {
                
                #line 487 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                Business.Correval.User.ObtenerGarantiasConstituidas(strIdClient, infoUsuario.InfoCliente.CuentaDerivados);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr59Get() {
                this.GetValueTypeValues();
                return this.@__Expr59Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr61GetTree() {
                
                #line 501 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
                                    Business.Correval.User.ConsultarCuentaClienteFuturos(strIdClient);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr61Get() {
                
                #line 501 "C:\TFS\TRADINGSOLUTION\DATAIFX.TRADING.ACTIVITY\INFOCLIENTACTIVITY.XAML"
                return 
                                    Business.Correval.User.ConsultarCuentaClienteFuturos(strIdClient);
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr61Get() {
                this.GetValueTypeValues();
                return this.@__Expr61Get();
            }
            
            protected override void GetValueTypeValues() {
                this.IngGarantiasConsumidas = ((decimal)(this.GetVariableValue((6 + locationsOffset))));
                this.lngGarantiasConstituidas = ((decimal)(this.GetVariableValue((7 + locationsOffset))));
                this.lngSaldoFuturos = ((decimal)(this.GetVariableValue((8 + locationsOffset))));
                base.GetValueTypeValues();
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
                if (((locationReferences[(offset + 3)].Name != "infoUsuario") 
                            || (locationReferences[(offset + 3)].Type != typeof(Dataifx.Trading.CommonObjects.InfoUsuario)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "AccountClient") 
                            || (locationReferences[(offset + 4)].Type != typeof(Dataifx.Trading.Infrastructure.Models.Account)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "dtSaldosNetos") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Data.DataTable)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "IngGarantiasConsumidas") 
                            || (locationReferences[(offset + 6)].Type != typeof(decimal)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "lngGarantiasConstituidas") 
                            || (locationReferences[(offset + 7)].Type != typeof(decimal)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "lngSaldoFuturos") 
                            || (locationReferences[(offset + 8)].Type != typeof(decimal)))) {
                    return false;
                }
                return InfoClientActivity_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
