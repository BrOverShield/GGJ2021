﻿ Shader "Unlit/PortalShader"
{
    
    SubShader
    {
		ZWrite off
		ColorMask 0 
	  Stencil
	  {
		Ref 99
		Pass replace
	  }

        Pass
        {
          
        }
      
        
    }
}
