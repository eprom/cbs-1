/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Concepts.HealthRisks;
using Dolittle.Commands;

namespace Domain.HealthRisks
{
    public class CreateHealthRisk : ICommand
    {
        public HealthRiskId Id {  get; set; }
        public HealthRiskName Name {  get; set; }
        public CaseDefinition CaseDefinition { get; set; }
        public HealthRiskNumber Number { get; set; }

        // TODO public KeyMessages KeyMessages { get; set; }
    }
}