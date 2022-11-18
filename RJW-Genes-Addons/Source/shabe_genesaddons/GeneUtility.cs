﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace shabe_genesaddons
{
    public class GeneUtility
    {
        public static bool IsMechbreeder(Pawn pawn)
        {
            return pawn.genes.HasGene(GeneDefOf.rjw_genes_mechbreeder);
        }

        public static bool IsInsectIncubator(Pawn pawn)
        {
            return pawn.genes.HasGene(GeneDefOf.rjw_genes_insectincubator);
        }

        public static float MaxEggSizeMul(Pawn pawn)
        {
            float MaxEggSize = 1;
            if (IsInsectIncubator(pawn))
            {
                MaxEggSize *= 2;
            }
            return MaxEggSize;
        }
    }
}