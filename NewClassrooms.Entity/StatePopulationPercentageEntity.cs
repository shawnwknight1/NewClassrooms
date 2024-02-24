﻿// -----------------------------------------------------------------------
// <copyright file="StatePopulationPercentageEntity.cs" company="Knight Technologies LLC">
// Author: Shawn W Knight
// Copyright (c) Knight Technologies LLC All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace NewClassrooms.Entity
{
    using GuardAgainstLib;
    using NewClassrooms.Entity.Interface;

    /// <summary>
    /// Provides an implementation of <see cref="IStatePopulationPercentageEntity"/>.
    /// </summary>
    public class StatePopulationPercentageEntity : IStatePopulationPercentageEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatePopulationPercentageEntity"/> class.
        /// </summary>
        /// <param name="state">A value that represents the state.</param>
        /// <param name="percentage">A value that represents the percentage of the gender.</param>
        public StatePopulationPercentageEntity(string state, double percentage)
        {
            this.State = GuardAgainst.ArgumentBeingNullOrEmpty(state, nameof(state));
            this.Percentage = GuardAgainst.ArgumentBeingOutOfRange(percentage, 0, 100, nameof(percentage));
        }

        /// <inheritdoc/>
        public string State { get; private set; }

        /// <inheritdoc/>
        public double Percentage { get; private set; }
    }
}
