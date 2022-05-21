package cipher;

import java.util.ArrayList;
import java.util.Collections;

public class Decrypt {
	public static final String ALPHABET = "abcdefghijklmnopqrstuvwxyz";
	public static ArrayList<String> listdecrypt = new ArrayList<String>();
	public static String[] tuthongdung = { "AI", "AO", "AU", "AY", "EO", "IA", "IU", "OA", "OE", "OI", "OO", "UA", "UI",
			"UO", "UY", "PH", "TH", "TR", "GI", "CH", "NH", "KH", "GH", "NG" };
	public static ArrayList<object> arrayList = new ArrayList<object>();

	public static String decrypt(String cipherText, int shiftKey) {
		cipherText = cipherText.toLowerCase();
		String message = "";
		for (int i = 0; i < cipherText.length(); i++) {
			if (cipherText.charAt(i) == '.') {
				message += ".";
				continue;
			}
			if (cipherText.charAt(i) == ' ') {
				message += " ";
				continue;
			}
			int charPosition = ALPHABET.indexOf(cipherText.charAt(i));
			int keyVal = (charPosition - shiftKey) % 26;
			if (keyVal < 0) {
				keyVal = ALPHABET.length() + keyVal;
			}
			char replaceVal = ALPHABET.charAt(keyVal);
			message += replaceVal;
		}
		return message.trim();
	}

	public static void getListDecryptString(String cipher) {
		for (int i = 0; i < 26; i++) {
			String s = decrypt(cipher, i);
			listdecrypt.add(s);
		}
	}

	public static void statisticalString(String cipher) { 
		getListDecryptString(cipher);
		for (int i = 0; i < listdecrypt.size(); i++) {
			int count = 0;
			String[] list = listdecrypt.get(i).split(" ");
			for (int j = 0; j < list.length; j++) {
				for (int k = 0; k < tuthongdung.length; k++) {
					if (list[j].toLowerCase().contains(tuthongdung[k].toLowerCase())) {
						count++;
					}
				}
			}
			object object = new object();
			object.setId(i);
			object.setTong(count);
			arrayList.add(object);
		}
		Collections.sort(arrayList); // SORT DESC
		System.out.println(arrayList.get(0).getId());
		System.out.println(decrypt(cipher, arrayList.get(0).getId()));
	}

	public static void main(String[] args) {
		String cipher = "XQKJ HWI YDE AI KE HW TWJD NKE YQJC LDWE IWQ. JCK ZQUAJ IEJD XAJ HWQ WE JCK HWE TW YWYD JDWQ.";
		statisticalString(cipher);
		
	}
}
