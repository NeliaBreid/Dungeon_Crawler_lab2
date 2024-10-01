
internal class LevelData
{
    private List<LevelElement> _elements;

	
	public List<LevelElement> Elements
	{
		get { return _elements; }
	}
	public void Load(string fileName)
	{
		_elements = new List<LevelElement>();

		_elements.Add( new Rat(3,4));
        _elements.Add(new Rat(6, 7));
        _elements.Add(new Snake(2, 4));
    }

}

