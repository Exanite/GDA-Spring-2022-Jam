using System;
using System.Collections.Generic;
using Project.Source.Utilities.Components;
using UnityEngine;

namespace Project.Source.Pathfinding
{
    public class Pathfinder : SingletonBehaviour<Pathfinder>
    {
        public List<PathfindingGrid> grids;

        public PathSolver GetSolver(Vector3 position)
        {
            foreach (var grid in grids)
            {
                if (grid.WorldPositionToNode(position) != null)
                {
                    return new PathSolver(grid);
                }
            }

            throw new ArgumentException($"Couldn't find {nameof(PathfindingGrid)} for position {position}");
        }
    }
}