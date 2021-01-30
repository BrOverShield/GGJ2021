 Shader "Unlit/PortalShader6"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 6
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
