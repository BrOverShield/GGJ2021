 Shader "Unlit/PortalShader7"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 7
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
