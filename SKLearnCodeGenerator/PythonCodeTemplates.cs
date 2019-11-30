using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKLearnCodeGenerator
{
    static class PythonCodeTemplates
    {
        public static string RegressionMetric(string y_true, string y_pred)
        {
            return $@"
import sklearn.metrics as metrics
def regression_results({y_true}, {y_pred}):

    # Regression metrics
    explained_variance=metrics.explained_variance_score({y_true}, {y_pred})
    mean_absolute_error=metrics.mean_absolute_error({y_true}, {y_pred}) 
    mse=metrics.mean_squared_error({y_true}, {y_pred}) 
    mean_squared_log_error=metrics.mean_squared_log_error({y_true}, {y_pred})
    median_absolute_error=metrics.median_absolute_error({y_true}, {y_pred})
    r2=metrics.r2_score({y_true}, {y_pred})

    print('explained_variance: ', round(explained_variance,4))    
    print('mean_squared_log_error: ', round(mean_squared_log_error,4))
    print('r2: ', round(r2,4))
    print('MAE: ', round(mean_absolute_error,4))
    print('MSE: ', round(mse,4))
    print('RMSE: ', round(np.sqrt(mse),4))

regression_results({y_true}, {y_pred})
";
        }

        public static string ClassificationMetric(string y_true, string y_pred)
        {
            return $@"
from sklearn.metrics import classification_report
print(classification_report({y_true}, {y_pred}))
";
        }
    }
}
