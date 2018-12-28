package md5a2862bca05aada37267341f0a97da991;


public class CircleEffect_CirlceOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("UXDivers.Effects.Droid.CircleEffect+CirlceOutlineProvider, UXDivers.Effects.Droid", CircleEffect_CirlceOutlineProvider.class, __md_methods);
	}


	public CircleEffect_CirlceOutlineProvider ()
	{
		super ();
		if (getClass () == CircleEffect_CirlceOutlineProvider.class)
			mono.android.TypeManager.Activate ("UXDivers.Effects.Droid.CircleEffect+CirlceOutlineProvider, UXDivers.Effects.Droid", "", this, new java.lang.Object[] {  });
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
