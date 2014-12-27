﻿using SharpLearning.Containers.Matrices;

namespace SharpLearning.Learners.Interfaces
{
    /// <summary>
    /// General interface for learner. 
    /// </summary>
    /// <typeparam name="TPrediction"></typeparam>
    public interface ILearner<TPrediction>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="observations"></param>
        /// <param name="targets"></param>
        /// <returns></returns>
        IPredictor<TPrediction> Learn(F64Matrix observations, double[] targets);
    }
}
