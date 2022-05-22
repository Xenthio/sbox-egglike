using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

[Library( "collectable_test" )]
[Display( Name = "Test Collectable" ), Category( "Collectables" ), Icon( "place" )]
public partial class TestCollectable : Collectable
{
	/// <summary>
	/// Help text in hammer
	/// </summary>
	[Property( Title = "Start Disabled" )]
	public bool StartDisabled { get; set; } = false;
	
	public override void Spawn()
	{
		base.Spawn();
		SetModel( "models/sbox_props/watermelon/watermelon.vmdl" );
	}
}
