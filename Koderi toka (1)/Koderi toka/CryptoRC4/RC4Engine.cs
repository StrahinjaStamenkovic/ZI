
using System;
using System.Globalization;
using System.Text;
using System.Collections;


namespace CryptoRC4
{
	/// <summary>
	/// Summary description for RC4Engine.
	/// </summary>
	public class RC4Engine
	{
		#region Costructor

		public RC4Engine()
		{
		}

		#endregion

		#region Public Method

		/// <summary>
		/// Encript InClear Text using RC4 method using EncriptionKey
		/// Put the result into CryptedText 
		/// </summary>
		/// <returns>true if success, else false</returns>
		public bool Encrypt()
		{
			//
			// toRet is used to store function retcode
			//
			bool toRet = true;

			try
			{
				//
				// indexes used below
				//
				long i=0;
				long j=0;

				//
				// Put input string in temporary byte array
				//
				Encoding enc_default = Encoding.Default;
				byte[] input  = enc_default.GetBytes(this.plainText);
				
				// 
				// Output byte array
				//
				byte[] output = new byte[input.Length];
				
				//
				// Local copy of keyLen
				//
				byte[] localKey = new byte[keyLen];
				this.key.CopyTo(localKey,0);
				
				//
				//	Len of Chipher
				//
				long ChipherLen = input.Length + 1;

				//
				// Run Alghoritm
				//
				for ( long offset = 0; offset < input.Length ; offset++ )
				{
					i = ( i + 1 ) % keyLen;
					j = ( j + localKey[i] ) %  keyLen; 
					byte temp =  localKey[i];
					localKey[i] = localKey[j];
					localKey[j] = temp;
					byte a = input[offset];
					byte b = localKey[(localKey[i]+localKey[j])% keyLen];
					output[offset] = (byte)((int)a^(int)b);	
				}	
				
				//
				// Put result into output string ( CryptedText )
				//
				char[] outarrchar = new char[enc_default.GetCharCount(output,0,output.Length)];
				enc_default.GetChars(output,0,output.Length,outarrchar,0);
				this.cryptedText = new string (outarrchar);
			}
			catch
			{
				//
				// error occured - set retcode to false.
				// 
				toRet = false;
			}

			//
			// return retcode
			//
			return ( toRet );

		}

		/// <summary>
		/// Decript CryptedText into InClearText using EncriptionKey
		/// </summary>
		/// <returns>true if success else false</returns>
		public bool Decrypt()
		{
			//
			// toRet is used to store function retcode
			//
			bool toRet = true;

			try
			{
				this.plainText = this.cryptedText;
				cryptedText = "";
				if (toRet = Encrypt())
				{
					plainText = cryptedText;
				}
			
			}
			catch
			{
				//
				// error occured - set retcode to false.
				// 
				toRet = false;
			}
			
			//
			// return retcode
			//
			return toRet;
		}
		
		#endregion

		#region Prop definitions
		/// <summary>
		/// Get or set Encryption Key
		/// </summary>
		public string EncryptionKey
		{
			get
			{
				return ( this.encryptionKey );
			}
			set
			{
				//
				// assign value only if it is a new value
				//
				if ( this.encryptionKey != value )
				{	
					this.encryptionKey = value;

					//
					// Used to populate key
					//
					long index2 = 0;

					//
					// Create two different encoding 
					//
					Encoding ascii		= Encoding.ASCII;
					Encoding unicode	= Encoding.Unicode;

					//
					// Perform the conversion of the encryption key from unicode to ansi
					//
					byte[] asciiBytes = Encoding.Convert(unicode,ascii,unicode.GetBytes(this.encryptionKey));

					//
					// Convert the new byte[] into a char[] and then to string
					//
					
					char[] asciiChars = new char[ascii.GetCharCount(asciiBytes,0,asciiBytes.Length)];
					ascii.GetChars(asciiBytes,0,asciiBytes.Length,asciiChars,0);
					this.encryptionKeyAscii = new string(asciiChars);

					//
					// Populate key
					//
					long KeyLen = encryptionKey.Length;
					
					//
					// First Loop
					//
					for ( long count = 0; count < keyLen ; count ++ )
					{
						this.key[count] = (byte)count;
					}
					
					//
					// Second Loop
					//
					for ( long count = 0; count < keyLen ; count ++ )
					{
						index2 = (index2 + key[count] + asciiChars[ count % KeyLen ]) % keyLen;
						
						byte temp	= key[count];
						key[count]	= key[index2];
						key[index2]	= temp;
					}

				}
			}
		}

		public string InClearText
		{
			get
			{
				return ( this.plainText );
			}
			set
			{
				//
				// assign value only if it is a new value
				//
				if (this.plainText	!= value)
				{	
					this.plainText	= value;
				}
			}
		}

		public string CryptedText
		{
			get
			{
				return ( this.cryptedText );
			}
			set
			{
				//
				// assign value only if it is a new value
				//
				if ( this.cryptedText != value )
				{	
					this.cryptedText = value;
				}
			}
		}
		#endregion

		#region Private Fields
		
		//
		// Encryption Key  - Unicode & Ascii version
		//
		private string encryptionKey	  = "";
		private string encryptionKeyAscii = "";
		//
		// It is related to Encryption Key
		//
		protected byte[] key = new byte[keyLen];
		//
		// Len of nBox
		//
		static public long keyLen = 255;
		
		//
		// In Clear Text
		//
		private string plainText	= "";
		private string cryptedText	= "";
		
		#endregion

	}
}
