using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imutabilidade
{
    public sealed class CuttingPlan
    {
        public IEnumerable<Shape> ShapeToCut { get; }
        public  IPlacementStrategy PlacementStrategy { get; }
        public double Margin { get; }
        public IEnumerable<CuttingLayout> Layouts { get; } 

        public CuttingPlan(IEnumerable<Shape> shapesToCut, IPlacementStrategy placementStrategy, double margin )
            : this(shapesToCut, placementStrategy, margin, new CuttingLayout[0])
        {}

        public CuttingPlan(IEnumerable<Shape> shapesToCut, IPlacementStrategy placementStrategy, double margin, IEnumerable<CuttingLayout> layouts )
        {
            ShapeToCut = shapesToCut;
            PlacementStrategy = placementStrategy;
            Margin = margin;
            Layouts = layouts;
        }

        public bool IsCompleted => !ShapeToCut.Any();

        public CuttingPlan AddLayout(CuttingLayout layout)
        {
            IEnumerable<Shape> newShapesToCut = ShapeToCut.Where(shape => layout.Placements.All(p => p.Shape != shape)).ToList();
            return new CuttingPlan(newShapesToCut, PlacementStrategy, Margin, Layouts.Concat(new[] {layout}));
        }
    }
}
