 Shader "Unlit/PortalShader4"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 4
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
