using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Hammer;

[Library( "collectable_test" )]
[Display( Name = "Test Collectable" ), Category( "Collectables" ), Icon( "place" )]
partial class TestCollectable : Collectable
{
	public override void Spawn()
	{
		base.Spawn();
	}
}
