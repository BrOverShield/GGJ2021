 Shader "Unlit/PortalShader3"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 3
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
