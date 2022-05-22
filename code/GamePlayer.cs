partial class GamePlayer : Player
{
	/// <summary>
	/// Called when the entity is first created 
	/// </summary>
	/// 
	public ClothingContainer Clothing = new();
	public override void Spawn()
	{
		SetModel( "models/citizen/citizen.vmdl" );
		Controller = new WalkController();

		Animator = new StandardPlayerAnimator();
		CameraMode = new FirstPersonCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;

		Clothing.DressEntity( this );
		base.Respawn();
	}

	/// <summary>
	/// Called every tick, clientside and serverside.
	/// </summary>
	public override void Simulate( Client cl )
	{
		base.Simulate( cl );
	}
}

