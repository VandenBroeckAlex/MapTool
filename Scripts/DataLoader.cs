using MapToolV2.Scripts.Interface;

namespace MapToolV2.Scripts
{
 
    public class DataLoader
    {
        
        public DataLoader(
            string rootFile,
            string scenario,
            bool createDataForOrphan,
            bool removeColorNotInImage,
            IComputeNeighbore computeNeighbor,
            IComputePivot computePivot,
            IComputeSurface computeSurface)
        {
            this.rootFile = rootFile;
            this.scenario = scenario;
            this.createDataForOrphan = createDataForOrphan;
            this.removeColorNotInImage = removeColorNotInImage;
            this.computeNeighbor = computeNeighbor;
            this.computePivot = computePivot;
            this.computeSurface = computeSurface;
        }

        public string rootFile { get; }
        public string scenario { get; }

        public bool createDataForOrphan { get; }
        public bool removeColorNotInImage { get; }

        // Strategies
        public IComputeNeighbore computeNeighbor { get; }
        public IComputePivot computePivot { get; }
        public IComputeSurface computeSurface { get; }




    }

    // The Builder
    public class DataLoaderBuilder
    {

        private readonly string _rootFile;
        private readonly string _scenario;

        private IComputeNeighbore _computeNeighbor = null;
        private IComputePivot _computePivot = null;
        private IComputeSurface _computeSurface = null;
        private bool _createDataForOrphan = false;
        private bool _removeColorNotInImage = false;


        public DataLoaderBuilder(string rootFile, string scenario)
        {
            _rootFile = rootFile ?? throw new ArgumentNullException(nameof(rootFile));
            _scenario = scenario ?? throw new ArgumentNullException(nameof(scenario));
        }


        public DataLoaderBuilder WithNeighbor(IComputeNeighbore strategy)
        {
            _computeNeighbor = strategy;
            return this;
        }

        public DataLoaderBuilder WithComputePivot(IComputePivot strategy)
        {
            _computePivot = strategy;
            return this;
        }

        public DataLoaderBuilder WithComputeSurface(IComputeSurface strategy)
        {
            _computeSurface = strategy;
            return this;
        }

        public DataLoaderBuilder WithDataForOrphan()
        {
            _createDataForOrphan = true;
            return this;
        }

        public DataLoaderBuilder WithRemoveColorNotInImage()
        {
            _removeColorNotInImage = true;
            return this;
        }

        public DataLoader Build()
        {
            return new DataLoader(
                _rootFile,
                _scenario,
                _createDataForOrphan,
                _removeColorNotInImage,
                _computeNeighbor,
                _computePivot,
                _computeSurface
            );
        }
    }


}