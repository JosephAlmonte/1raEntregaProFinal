using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DatosPlanetas : MonoBehaviour
{
	
	public TextMeshProUGUI PlanetaNombre,PlanetaNpombreGrande,Definicion,MiniInfo;
	
	public TextMeshProUGUI NombreLuna1,DefinicionLuna1,DifinicionPeqLuna1;
	
	public TextMeshProUGUI NombreLuna2,DefinicionLuna2,DifinicionPeqLuna2;
	
	public TextMeshProUGUI NombreLuna3,DefinicionLuna3,DifinicionPeqLuna3;
	
	public TextMeshProUGUI NombreLuna4,DefinicionLuna4,DifinicionPeqLuna4;
	
	
	public GameObject InfoLuna1,InfoLuna2,InfoLuna3,InfoLuna4,EsferaPlaneta,EsferaLuna,EsferaLuna2,EsferaLuna3,EsferaLuna4;
	
	
	public Material MaterialTierra,materialLunaT,MaterialMarte,MaterialLapetus,MaterialTitan,MaterialDione,MaterialEnceladus,MaterialMercurio;
	
	public Material MaterialAriel,MaterialOberon,MaterialMiranda,MaterialTitania,MaterialUrano,materialPluton;
	
	
	public GameObject Fobosa,Deimos,Saturno,nix,Hydra,Sol,FotoImagen;
	
	public Material MaterialTriton,MaterialProteo,MaterialLarisa,MaterialNeptuno,MaterialVenus;
	
	
	public Material MaterialJupiter,MaterialCalisto,MaterialIo,Materialganimedes,MaterialEuropa;
	
	
	public Image Foto,Pantalla;
	
	public Sprite []spri;
	
	public GameObject Luna;
	
	
	void Start()
	{
		
		InfoPlaneta(1);
		FotoImagen.SetActive(false);
		//Espacio=GameObject.FindGameObjectWithTag("Espacio").GetComponent<DatosPlanetas>();
		
	}
	
	
  
	public void InfoPlaneta(int Planeta)
	{
		Iniciacion();
		switch (Planeta)
		{
		
		case 1:
		
		
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialTierra;
			PlanetaNombre.text="Planeta Tierra";
			PlanetaNpombreGrande.text="La Tierra";
			Definicion.text="La Tierra se formó hace aproximadamente 4550 millones de años y la vida surgió unos mil millones de años después.​"+
				" Es el hogar de millones de especies, incluidos los seres humanos y actualmente el único cuerpo astronómico donde se conoce la "+
				"existencia de vida. La atmósfera y otras condiciones abióticas han sido alteradas significativamente por la biosfera del planeta,"+
				" favoreciendo la proliferación de organismos aerobios, así como la formación de una capa de ozono que junto con el campo magnético "+
				"terrestre bloquean la radiación solar dañina, permitiendo así la vida en la Tierra. Las propiedades físicas de la Tierra, la historia"+
				" geológica y su órbita han permitido que la vida siga existiendo.";
				
			
			MiniInfo.text="Edad: 4,543 miles de millones años \n" +
				"Distancia desde el Sol: 149,6 millones km\n" +
				"Superficie: 510,1 millones km²\n" +
				"Superficie: 148,9 millones km²\n" +
				"Radio: 6.371 km\n" +
				"Gravedad: 9,807 m/s²"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = materialLunaT;
				
			NombreLuna1.text="Luna";
			DefinicionLuna1.text="La Luna es el único satélite natural de la Tierra. Con un diámetro ecuatorial de 3476 km,"+
				" es el quinto satélite más grande del sistema solar, mientras que en cuanto al tamaño proporcional respecto a"+
				" su planeta es el satélite más grande: un cuarto del diámetro de la Tierra y 1/81 de su masa.";
				
			DifinicionPeqLuna1.text="Gravedad: 1,62 m/s²\n" +
				"Edad: 4,53 miles de millones años\n" +
				"Período orbital: 27 días\n" +
				"Radio: 1.737,4 km\n" +
				"Distancia a la Tierra: 384.400 km\n" +
				"Órbitas: Tierra\n" +
				"Dióxido de carbono: trazas\n";
		
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
		
		
			break;
		
		
		case 2:
		
		
			
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
		
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialMarte;
			PlanetaNombre.text="Planeta Marte";
			PlanetaNpombreGrande.text="Marte";
			Definicion.text="Marte es el cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar, después de Mercurio.";
				
			
			MiniInfo.text="Distancia desde el Sol: 227,9 millones km\n"+
				"Duración del día: 1d 0h 37m\n"+
				"Radio: 3.389,5 km\n"+
				"Superficie: 144,8 millones km²\n"+
				"Gravedad: 3,721 m/s²\n"+
				"Período orbital: 687 días\n"+
				"Lunas: Fobos, Deimos"
				;
				
				
				
				
			EsferaLuna.SetActive(false);
			Fobosa.SetActive(true);
				
			NombreLuna1.text="Luna Fobos";
			DefinicionLuna1.text="Fobos es el más grande de los dos satélites de Marte y el más cercano al planeta, siendo Deimos el otro "+
				"satélite. Ambos fueron descubiertos por el astrónomo estadounidense Asaph Hall el 18 de agosto de 1877, con el gran refractor de"+
				" 66 cm del Observatorio Naval de los Estados Unidos de Washington D. ";
				
			DifinicionPeqLuna1.text="Radio: 11,267 km\n"+
				"Gravedad: 0,0057 m/s²\n"+
				"Distancia a la Tierra: 77,79 millones km\n"+
				"Albedo: 0,07\n"+
				"Densidad: 1,85 g/cm³\n"+
				"Dimensiones: 26,8×21×18,4 km\n"+
				"Descubridores: Asaph Hall, Pascal Lee\n"
				;
		
			
			
			EsferaLuna2.SetActive(false);
			Deimos.SetActive(true);
				
			NombreLuna2.text="Luna Deimos";
			DefinicionLuna2.text="Deimos es el más pequeño y externo de los dos satélites de Marte y uno de los satélites más"+
				" pequeños que han recibido nombre, llamado así por Deimos, un personaje de la mitología griega.";
				
			DifinicionPeqLuna2.text="Radio: 6,2 km\n"+
				"Gravedad: 0,003 m/s²\n"+
				"Edad: 4,503 miles de millones años\n"+
				"Fecha de descubrimiento: 12 de agosto de 1877\n"+
				"Densidad: 1,47 g/cm³\n"+
				"Magnitud Aparente (V): 12,89\n"+
				"Descubridores: Asaph Hall, Pascal Lee"
				;
			
			
		
		
		
			break;
			
			
			
		case 3:
		
			EsferaPlaneta.SetActive(false);
			Saturno.SetActive(true);
			
			PlanetaNombre.text="Planeta Saturno";
			PlanetaNpombreGrande.text="Saturno";
			Definicion.text="Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después"+
				" de Júpiter y el único con un sistema de anillos visible desde la Tierra.";
				
			
			MiniInfo.text="Gravedad: 10,44 m/s²\n"+
				"Distancia desde el Sol: 1,434 miles de millones km\n"+
				"Superficie: 42,7 miles de millones km²\n"+
		"Duración del día: 0d 10h 34m\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Densidad: 687 kg/m³\n"+
		"Lunas: Titán, Encélado, Mimas, Dione, Jápeto, Tetis, Hiperión, MÁS"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = MaterialLapetus;
			EsferaLuna2.GetComponent<MeshRenderer>().material = MaterialTitan;
			EsferaLuna3.GetComponent<MeshRenderer>().material = MaterialDione;
			EsferaLuna4.GetComponent<MeshRenderer>().material = MaterialEnceladus;
				
				
				
			NombreLuna1.text="Lapetus";
			DefinicionLuna1.text="Jápeto es uno de los satélites del planeta Saturno. Es el octavo más distante al planeta y el tercero en"+
				" tamaño, con un diámetro de alrededor de 1500 km, después de los satélites más grandes Titán y Rea. Fue descubierto por Giovanni"+
				" Cassini en 1671.";
				
			DifinicionPeqLuna1.text="Radio: 734,5 km\n"+
				"Gravedad: 0,223 m/s²\n"+
				"Período orbital: 79 días\n"+
		"Edad: 4,567 miles de millones años\n"+
		"Fecha de descubrimiento: 25 de octubre de 1671\n"+
				"Densidad: 1,09 g/cm³";
		
			
			NombreLuna2.text="Titan";
			DefinicionLuna2.text="Titán es el mayor de los satélites de Saturno y el segundo del sistema solar tras Ganimedes. Además, es el único satélite conocido que posee una atmósfera importante, ​ y el único objeto, aparte de la"+
				" Tierra, en el que se ha encontrado evidencia clara de cuerpos líquidos estables en la superficie.​";
				
			DifinicionPeqLuna2.text="Gravedad: 1,352 m/s²\n"+
				"Edad: 4,003 miles de millones años\n"+
		"Radio: 2.574,7 km\n"+
		"Período orbital: 16 días\n"+
		"Fecha de descubrimiento: 25 de marzo de 1655\n"+
				"Densidad: 1,88 g/cm³";
		
			
			
			NombreLuna3.text="Dione";
			DefinicionLuna3.text="Dione es un satélite natural de Saturno descubierto en 1684 por Giovanni Cassini; el nombre proviene"+
				" de la mitología griega. Cassini nombró a las cuatro lunas descubiertas por él Sidera Lodoicea en honor al rey Luis XIV. ";
				
			DifinicionPeqLuna3.text="Radio: 561,4 km\n"+
				"Fecha de descubrimiento: 30 de marzo de 1684\n"+
		"Gravedad: 0,232 m/s²\n"+
		"Densidad: 1,48 g/cm³\n"+
				"Período orbital: 66 horas";
		
		
			NombreLuna4.text="Encelatus";
			DefinicionLuna4.text="Encélado es el sexto satélite más grande de Saturno con algo"+
				" más de 500 km de diámetro, ​ aproximadamente la décima parte del de Titán, el mayor satélite saturniano.";
				
			DifinicionPeqLuna4.text="Gravedad: 0,113 m/s²\n"+
				"Radio: 252,1 km\n"+
		"Fecha de descubrimiento: 1789\n"+
		"Período orbital: 33 horas\n"+
				"Densidad: 1,61 g/cm³";
		
			
			break;
			
			
			
			
		case 4:
			
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialMercurio;
			PlanetaNombre.text="Planeta Mercurio";
			PlanetaNpombreGrande.text="Mercurio";
			Definicion.text="Mercurio es el planeta del sistema solar más cercano al Sol y el más pequeño. Forma"+
				" parte de los denominados planetas interiores y carece de satélites naturales al igual que Venus.";
				
			
			MiniInfo.text="Gravedad: 3,7 m/s²\n"+
				"Masa: 3,285 × 10^23 kg (0,055 M⊕\n"+
		"Duración del día: 58d 15h 30m\n"+
		"Período orbital: 88 días\n"+
		"Densidad: 5,43 g/cm³\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Distancia desde el Sol: 58 millones km"
				;
				
		
		
			break;
			
			
		
		
		
		case 5:
			
			EsferaPlaneta.SetActive(true);
			
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialUrano;
			PlanetaNombre.text="Planeta Urano  ";
			PlanetaNpombreGrande.text="Urano";
			Definicion.text="Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo."+
				" Se llama así en honor de la divinidad griega del cielo Urano, el padre de Crono y el abuelo de Zeus.";
				
			
			MiniInfo.text="Gravedad: 8,87 m/s²\n"+
				"Distancia desde el Sol: 2,871 miles de millones km\n"+
		"Duración del día: 0d 17h 14m\n"+
		"Radio: 25.362 km\n"+
		"Superficie: 8,083 miles de millones km²\n"+
		"Fecha de descubrimiento: 13 de marzo de 1781\n"+
		"Lunas: Titania, Miranda, Oberón, Umbriel, Ariel, Puck, Desdémona, MÁS"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = MaterialAriel;
			EsferaLuna2.GetComponent<MeshRenderer>().material = MaterialOberon;
			EsferaLuna3.GetComponent<MeshRenderer>().material = MaterialMiranda;
			EsferaLuna4.GetComponent<MeshRenderer>().material = MaterialTitania;
				
				
				
			NombreLuna1.text="Ariel";
			DefinicionLuna1.text="Ariel es el cuarto satélite más grande de Urano y el segundo en proximidad"+
				" de los satélites principales. Fue descubierto en 1851 por William Lassell y nombrado por un personaje"+
				" de dos diferentes obras de la literatura inglesa.";
				
			DifinicionPeqLuna1.text="Radio: 578,9 km\n"+
				"Fecha de descubrimiento: 1851\n"+
		"Período orbital: 60 horas\n"+
		"Gravedad: 0,249 m/s²\n"+
				"Densidad: 1,59 g/cm³";
		
			
			NombreLuna2.text="Oberón";
			DefinicionLuna2.text="Oberón o Urano IV es el más exterior de los satélites principales del planeta Urano. Es el segundo más grande y masivo de Urano y el noveno más masivo del sistema solar.​";
				
			DifinicionPeqLuna2.text="Radio: 761,4 km\n"+
				"Gravedad: 0,354 m/s²\n"+
		"Período orbital: 13 días\n"+
				"Densidad: 1,63 g/cm³";
		
			
			
			NombreLuna3.text="Miranda";
			DefinicionLuna3.text="Miranda, también designado como Urano I, es el menor de los cinco satélites principales del planeta"+
				" Urano y el último en ser descubierto hasta el sobrevuelo de Urano por la sonda espacial Voyager 2.";
				
			DifinicionPeqLuna3.text="Gravedad: 0,079 m/s²\n"+
				"Radio: 235,8 km\n"+
		"Período orbital: 34 horas\n"+
				"Distancia a la Tierra: 2,723 miles de millones km";
		
		
			NombreLuna4.text="Titania";
			DefinicionLuna4.text="Titania, también designado como Urano III, es el mayor de los satélites del planeta Urano y el octavo del sistema"+
				" solar. Descubierto por William Herschel el 11 de enero de 1787, Titania recibe su nombre de un personaje, la"+
				" reina de las Hadas, de la obra de William Shakespeare El sueño de una noche de verano. ";
				
			DifinicionPeqLuna4.text="Radio: 788,4 km\n"+
				"Período orbital: 209 horas\n"+
		"Gravedad: 0,367 m/s²\n"+
		"Densidad: 1,71 g/cm³\n"+
				"Distancia a la Tierra: 2,723 miles de millones km";
		
			
			break;
		
		
		
		
		
		
		
		
		case 6:
		
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
		
			EsferaPlaneta.GetComponent<MeshRenderer>().material = materialPluton;
			PlanetaNombre.text="Planeta Plutón";
			PlanetaNpombreGrande.text="Plutón";
			Definicion.text="Plutón, designado Pluto, es un planeta enano del sistema solar situado a continuación"
				+" de la órbita de Neptuno. Su nombre se debe al dios mitológico romano Plutón.";
				
			
			MiniInfo.text="Radio: 1.188,3 km\n"+
				"Gravedad: 0,62 m/s²\n"+
		"Fecha de descubrimiento: 18 de febrero de 1930\n"+
		"Magnitud absoluta: -0,7\n"+
		"Período orbital: 248 años\n"+
		"Descubridor: Clyde Tombaugh\n"+
		"Lunas: Caronte, Nix, Estigia, Cerbero, Hidra"
				;
				
				
				
				
			EsferaLuna.SetActive(false);
			nix.SetActive(true);
				
			NombreLuna1.text="Luna Nix";
			DefinicionLuna1.text="Nix es un satélite del sistema binario constituido por Plutón y Caronte. Fue descubierto"+
				" a finales de 2005 junto con Hidra y el telescopio espacial Hubble confirmó su presencia en febrero de 2006. ";
				
			DifinicionPeqLuna1.text="Fecha de descubrimiento: 15 de mayo de 2005\n"+
				"Gravedad: 0.000163 m/s²\n"+
		"Período orbital: 25 días\n"+
		"Magnitud Aparente (V): 23.38\n"+
		"Descubridor: Marc Buie"
				;
		
			
			
			EsferaLuna2.SetActive(false);
			Hydra.SetActive(true);
				
			NombreLuna2.text="Luna Hidra";
			DefinicionLuna2.text="Hidra es un satélite del sistema binario constituido por Plutón y Caronte. Fue descubierto a finales de 2005 y el Telescopio espacial Hubble confirmó su presencia en febrero de 2006.";
				
			DifinicionPeqLuna2.text=" Se denominó provisionalmente S/2005 P 1 hasta que en junio de 2006 la Unión Astronómica Internacional lo bautizó como Hidra."
				;
			
			
		
			break;
		
		
		
		
		case 7:
		
			InfoLuna4.SetActive(false);
		

			EsferaPlaneta.SetActive(true);
			
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialNeptuno;
			PlanetaNombre.text="Planeta Neptuno  ";
			PlanetaNpombreGrande.text="Neptuno";
			Definicion.text="Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de"+
				" los denominados planetas exteriores, y dentro de estos, es uno de los gigantes helados, y es el primero que fue descubierto gracias"+
				" a predicciones matemáticas. ";
				
			
			MiniInfo.text="Distancia desde el Sol: 4,495 miles de millones km\n"+
				"Duración del día: 0d 16h 6m\n"+
		"Gravedad: 11,15 m/s²\n"+
		"Radio: 24.622 km\n"+
		"Superficie: 7,618 miles de millones km²\n"+
		"Fecha de descubrimiento: 23 de septiembre de 1846"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = MaterialTriton;
			EsferaLuna2.GetComponent<MeshRenderer>().material = MaterialProteo;
			EsferaLuna3.GetComponent<MeshRenderer>().material = MaterialLarisa;
			
				
				
				
			NombreLuna1.text="Tritón";
			DefinicionLuna1.text="Tritón es un satélite de Neptuno que se encuentra a 4500 millones de kilómetros del Sol. Es uno de los astros más fríos del sistema solar."+
				" Descubierto por William Lassell el 10 de octubre de 1846, ​solo 17 días después del propio descubrimiento del planeta, debe su"+
				" nombre al dios Tritón de la mitología griega.";
				
			DifinicionPeqLuna1.text="Fecha de descubrimiento: 1846\n"+
				"Edad: 4,503 miles de millones años\n"+
		"Densidad: 2,06 g/cm³\n"+
		"Distancia a la Tierra: 4,338 miles de millones km\n"+
		"Gravedad: 0,779 m/s²\n"+
			"Magnitud Aparente (V): 13,47\n"+
				"Descubridor: William Lassell";
		
			
			
			
			NombreLuna2.text="Proteo";
			DefinicionLuna2.text="Proteo es el segundo satélite más grande de Neptuno, detrás de Tritón. Fue descubierto"+
				" en 1989 por Stephen Synnott gracias a las imágenes tomadas por la sonda espacial Voyager 2.​";
				
			DifinicionPeqLuna2.text="Radio: 210 km\n"+
				"Gravedad: 0,07 m/s²\n"+
		"Período orbital: 27 horas\n"+
		"Fecha de descubrimiento: 16 de junio de 1989\n"+
		"Densidad: 1,3 g/cm³\n"+
		"Órbitas: Neptuno\n"+
				"Descubridores: Stephen Synnott, Bradford A. Smith";
		
			
			
			NombreLuna3.text="Larisa";
			DefinicionLuna3.text="Larisa, o Neptuno VII, es un pequeño satélite natural del planeta Neptuno."+
				" Su nombre procede de Larisa, heroína argiva, hija de Pelasgo, amante de Poseidón.";
				
			DifinicionPeqLuna3.text="Radio: 97 km\n"+
				"Gravedad: 0,03 m/s²\n"+
		"Fecha de descubrimiento: 24 de mayo de 1981\n"+
		"Período orbital: 13 horas\n"+
		"Nombre provisional: S/1981 N 1\n"+
		"Orbita a: Neptuno\n"+
				"Periodo de rotación: 0,555 días";
		
		
		
			break;
		
		
		
		case 8:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialVenus;
			PlanetaNombre.text="Planeta Venus";
			PlanetaNpombreGrande.text="Venus";
			Definicion.text="Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto"+
				" a tamaño en orden ascendente después de Mercurio y Marte. Al igual que Mercurio, carece de satélites naturales.";
				
			
			MiniInfo.text="Gravedad: 8,87 m/s²\n"+
				"Duración del día: 116d 18h 0m\n"+
		"Masa: 4,867 × 10^24 kg (0,815 M⊕)\n"+
		"Período orbital: 225 días\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Densidad: 5,24 g/cm³\n"+
		"Distancia desde el Sol: 108,2 millones km"
				;
				
		
		
			break;
			
		
		
		
		
		
		case 9:
		
		
			EsferaPlaneta.SetActive(true);
			
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialJupiter;
			PlanetaNombre.text="Planeta Jupiter  ";
			PlanetaNpombreGrande.text="Jupiter";
			Definicion.text="Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol.​"+
				" Es un gigante gaseoso que forma parte de los denominados planetas exteriores. ";
				
			
			MiniInfo.text="Lunas: Europa, Ío, Ganimedes, Calisto, Amaltea, Adrastea, Valetudo, MÁS Tema del momento\n"+
				"Superficie: 61,42 miles de millones km²\n"+
		"Radio: 69.911 km\n"+
		"Duración del día: 0d 9h 56m\n"+
		"Período orbital: 12 años\n"+
		"Edad: 4,603 miles de millones años\n"+
		"Densidad: 1,33 g/cm³"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = MaterialCalisto;
			EsferaLuna2.GetComponent<MeshRenderer>().material = MaterialIo;
			EsferaLuna3.GetComponent<MeshRenderer>().material = Materialganimedes;
			EsferaLuna4.GetComponent<MeshRenderer>().material = MaterialEuropa;
				
				
				
			NombreLuna1.text="Calisto";
			DefinicionLuna1.text="Calisto es un satélite del planeta Júpiter descubierto en 1610 por Galileo Galilei.​ Es el tercer satélite más grande del sistema solar y el segundo del sistema joviano,"+
				" después de Ganimedes. Calisto tiene aproximadamente el 99 % del diámetro del planeta Mercurio, pero solo un tercio de su masa.";
				
			DifinicionPeqLuna1.text="Radio: 2.410,3 km\n"+
				"Gravedad: 1,236 m/s²\n"+
		"Fecha de descubrimiento: 7 de enero de 1610\n"+
		"Densidad: 1,83 g/cm³\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Período orbital: 17 días\n"+
				"Descubridor: Galileo Galilei";
		
		
		
			
			NombreLuna2.text="Ío";
			DefinicionLuna2.text="Ío es el satélite galileano más cercano a Júpiter. Es el tercer satélite por su tamaño, tiene la más alta densidad entre todos los satélites y,"+
				" en proporción, la menor cantidad de agua entre todos los objetos conocidos del sistema solar. Fue descubierto por Galileo Galilei en 1610.";
				
			DifinicionPeqLuna2.text="Radio: 1.821,6 km\n"+
				"Fecha de descubrimiento: 8 de enero de 1610\n"+
		"Densidad: 3,53 g/cm³\n"+
		"Período orbital: 42 horas\n"+
		"Gravedad: 1,796 m/s²\n"+
		"Distancia a la Tierra: 628,3 millones km\n"+
				"Descubridor: Galileo Galilei";
		
			
			
			NombreLuna3.text="Ganimedes";
			DefinicionLuna3.text="Ganimedes es el satélite natural más grande de Júpiter y del sistema solar, ​ además de ser el único"+
				" que tiene campo magnético. En orden de distancias al planeta,"+
				" es el séptimo más cercano y el tercero de los galileanos, el primer grupo de objetos descubiertos que orbitan alrededor de un planeta.";
				
			DifinicionPeqLuna3.text=
				"Radio: 2.634,1 km\n"+
		"Gravedad: 1,428 m/s²\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Período orbital: 172 horas\n"+
		"Densidad: 1,94 g/cm³\n"+
		"Fecha de descubrimiento: 7 de enero de 1610\n"+
				"Descubridores: Galileo Galilei, Simon Marius";
		
		
			NombreLuna4.text="Europa";
			DefinicionLuna4.text="Europa es el sexto satélite natural de Júpiter en orden creciente de distancia"+
				" y el más pequeño de los cuatro satélites galileanos. Fue descubierto en 1610 por Galileo ​ y nombrado por Europa,"+
				" la madre del rey Minos de Creta y amante de Zeus.";
				
			DifinicionPeqLuna4.text="Radio: 1.560,8 km\n"+
				"Gravedad: 1,315 m/s²\n"+
		"Edad: 4,503 miles de millones años\n"+
		"Fecha de descubrimiento: 8 de enero de 1610\n"+
		"Período orbital: 85 horas\n"+
				"Densidad: 3,01 g/cm³";
		
			
			break;
		
		
		
		
		case 10:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
		
			EsferaPlaneta.SetActive(false);
			Sol.SetActive(true);
			
			PlanetaNombre.text="El Sol";
			PlanetaNpombreGrande.text="Sol";
			Definicion.text="El Sol ​ es una estrella de tipo-G de la secuencia principal y clase de luminosidad V que se encuentra "+
				"en el centro del sistema solar y constituye la mayor fuente de radiación electromagnética de este sistema planetario.Se formó hace aproximadamente 4600 millones de años a partir del colapso gravitacional de la materia dentro de una región de una gran"+
				" nube molecular.";
				
			
			MiniInfo.text="La mayor parte de esta materia se acumuló en el centro, mientras que el resto se aplanó en un disco en órbita que se convirtió en"+
				" el sistema solar. La masa central se volvió cada vez más densa y caliente, dando lugar con el tiempo al inicio de la fusión nuclear en su núcleo. Se"+
				" cree que casi todas las estrellas se forman por este proceso. El Sol es más o menos de edad intermedia y no ha cambiado drásticamente desde hace más de"+
				" cuatro mil millones de años, y seguirá siendo bastante estable durante otros 5000 millones de años más."
				;
		
		
			break;
		
		
		
		case 11:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			EsferaPlaneta.SetActive(false);
			FotoImagen.SetActive(true);

			Foto.sprite=spri[0];
			
			
			
			PlanetaNombre.text="galaxia de Andrómeda";
			PlanetaNpombreGrande.text="Andrómeda";
			Definicion.text="La galaxia de Andrómeda, también conocida como Galaxia Espiral M31, Messier 31 o NGC 224, es una galaxia espiral con un "+
				"diámetro de doscientos veinte mil años luz (en lo que concierne a su halo galáctico) y de unos ciento cincuenta mil años luz entre los extremos"+
				" de sus brazos.";
				
			
			MiniInfo.text="Es el objeto visible a simple vista más lejano de la Tierra (aunque algunos afirman poder ver a simple vista"+
				" la galaxia del Triángulo, que está un poco más lejos).";
				
		
			break;
		
		
		
		
		case 12:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[1];
			
			
			
			PlanetaNombre.text="galaxia de Triángulo ";
			PlanetaNpombreGrande.text="Triángulo ";
			Definicion.text="La galaxia del Triángulo (también conocida como galaxia espiral M33, Objeto Messier 33, Messier 33, M33 o NGC 598)"+
				" es una galaxia espiral localizada en la constelación del Triangulum. Con entre 30 000 y 40 000 millones de estrellas.";
				
			
			MiniInfo.text="Es pequeña en comparación con sus vecinas mayores, la Vía Láctea y la galaxia de Andrómeda que tienen, respectivamente,"+
				" entre 200 000 y 400 000 millones y un billón de estrellas, pero su tamaño es parecido al del resto de galaxias espirales del universo.";
				
			
		
			break;
		
		
		case 13:
			Luna.SetActive(true);
		
		
			EsferaPlaneta.GetComponent<MeshRenderer>().material = MaterialTierra;
			PlanetaNombre.text="Planeta Tierra";
			PlanetaNpombreGrande.text="La Tierra";
			Definicion.text="La Tierra se formó hace aproximadamente 4550 millones de años y la vida surgió unos mil millones de años después.​"+
				" Es el hogar de millones de especies, incluidos los seres humanos y actualmente el único cuerpo astronómico donde se conoce la "+
				"existencia de vida. La atmósfera y otras condiciones abióticas han sido alteradas significativamente por la biosfera del planeta,"+
				" favoreciendo la proliferación de organismos aerobios, así como la formación de una capa de ozono que junto con el campo magnético "+
				"terrestre bloquean la radiación solar dañina, permitiendo así la vida en la Tierra. Las propiedades físicas de la Tierra, la historia"+
				" geológica y su órbita han permitido que la vida siga existiendo.";
				
			
			MiniInfo.text="Edad: 4,543 miles de millones años \n" +
				"Distancia desde el Sol: 149,6 millones km\n" +
				"Superficie: 510,1 millones km²\n" +
				"Superficie: 148,9 millones km²\n" +
				"Radio: 6.371 km\n" +
				"Gravedad: 9,807 m/s²"
				;
				
				
				
				
			EsferaLuna.GetComponent<MeshRenderer>().material = materialLunaT;
				
			NombreLuna1.text="Luna";
			DefinicionLuna1.text="La Luna es el único satélite natural de la Tierra. Con un diámetro ecuatorial de 3476 km,"+
				" es el quinto satélite más grande del sistema solar, mientras que en cuanto al tamaño proporcional respecto a"+
				" su planeta es el satélite más grande: un cuarto del diámetro de la Tierra y 1/81 de su masa.";
				
			DifinicionPeqLuna1.text="Gravedad: 1,62 m/s²\n" +
				"Edad: 4,53 miles de millones años\n" +
				"Período orbital: 27 días\n" +
				"Radio: 1.737,4 km\n" +
				"Distancia a la Tierra: 384.400 km\n" +
				"Órbitas: Tierra\n" +
				"Dióxido de carbono: trazas\n";
		
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
		
		
		
			break;
		
		
		case 14:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[2];
			
			
			
			PlanetaNombre.text="Nebulosa Medusa";
			PlanetaNpombreGrande.text="Medusa";
			Definicion.text="La Nebulosa Medusa es una gran nebulosa planetaria ubicada en la constelación de Gémini en un sector que limita con la constelación de Canis Minor." +
				"Hasta principios de los años 1970, la Medusa era considerada como resto de supernova. Estudios posteriores realizados por astrónomos soviéticos en 1971 concluyeron que se parecía más a una" +
				"nebulosa planetaria que a los restos de una supernova";
				
			
			MiniInfo.text="Como la nebulosa es tan grande, su brillo superficial es muy bajo, con magnitudes superficiales de entre +15.99 y" +
				"+25 reportadas. Debido a esto, para su observación se recomienda al menos un telescopio de 8 pulgadas (200 mm) para encontrar este objeto, aunque probablemente sea posible obtener" +
				"imágenes con aperturas más pequeñas.";
				
			
		
			break;
		
		
		
		case 15:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[3];
			
			
			
			PlanetaNombre.text="Crescent Nebula";
			PlanetaNpombreGrande.text="Crescent Nebula";
			Definicion.text="La nebulosa Medialuna (NGC 6888), también llamada nebulosa Creciente o Caldwell 27," +
				"es una nebulosa de emisión en la constelación de Cygnus, situada 6º al suroeste de Sadr (γ Cygni)." +
				"Se encuentra a unos 4700 años luz de distancia de la Tierra.";
				
			
			MiniInfo.text="La nebulosa Medialuna es una nebulosa de Wolf-Rayet, formada por el fuerte viento estelar originado por" +
				"la estrella de Wolf-Rayet WR 136 que choca y dinamiza el viento más lento que expulsó la estrella" +
				"cuando se convirtió en una gigante roja hace unos 400 000 años. A resultas de esta colisión se ha" +
				"formado una envoltura y dos ondas de choque, una moviéndose hacia afuera y otra hacia dentro." +
				"La onda de choque que se mueve hacia el interior calienta el viento estelar hasta temperaturas" +
				"en donde se emiten rayos X.";
				
			
		
			break;
		
		
		
	
		
		
		case 16:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[4];
			
			
			
			PlanetaNombre.text="Tadpole Nebula";
			PlanetaNpombreGrande.text="Tadpole Nebula";
			Definicion.text="La nebulosa conocida como IC 410 alberga un par de intrigantes estructuras conocidas popularmente como renacuajos." +
				"Estos son cúmulos de gas y polvo que quedaron de la formación del cúmulo, y es probable que estén" +
				"formando nuevas estrellas dentro de ellos.";
				
			
			MiniInfo.text="Las colas de los renacuajos son causadas por la presión de radiación y el viento solar"+
				" de las estrellas de NGC 1893; observe cómo apuntan lejos del cúmulo estelar.";
				
			
		
			break;
		
		
		
		case 17:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[5];
			
			
			
			PlanetaNombre.text="nebulosa de la Medusa";
			PlanetaNpombreGrande.text="nebulosa de la Medusa";
			Definicion.text="IC 443, también llamado SNR G189.1+03.0, 3C 157, Sh2-248 y CTB 20," +
				"es un resto de supernova situado en la constelación de Géminis. Tiene un diámetro " +
				"aproximado de 50 minutos de arco y pertenece a la asociación estelar Gem OB1." +
				"​Informalmente también recibe el nombre de nebulosa de la Medusa.​";
				
			
			MiniInfo.text="IC 443 es un resto de supernova de morfología mixta.​En el espectro visible" +
				"y en radiofrecuencias, muestra una morfología de concha o caparazón, y consta de dos" +
				"subcapas interconectadas, cada una de ellas de diferente tamaño y con un centro distinto." +
				"Una tercera subcapa más grande, inicialmente atribuida a IC 443, ahora es considerada el resto" +
				"de otra supernova más antigua (de aproximadamente 100 000 años de edad), llamado G189.6+3.3.​";
				
			
		
			break;
		
		
		case 18:
		
			InfoLuna1.SetActive(false);
			InfoLuna2.SetActive(false);
			InfoLuna3.SetActive(false);
			InfoLuna4.SetActive(false);
			
			FotoImagen.SetActive(true);

			EsferaPlaneta.SetActive(false);
			Foto.sprite=spri[6];
			
			
			
			PlanetaNombre.text="Nebulosa Trífida";
			PlanetaNpombreGrande.text="Nebulosa Trífida";
			Definicion.text="La nebulosa Trífida1 (también conocida como Messier 20 y NGC 6514) es una región H II en" +
				"la constelación de Sagitario. Fue catalogada por primera vez en 1764 por el astrónomo francés" +
				"Charles Messier. El nombre Trífida, fue acuñado por el astrónomo John Herschel," +
				"y significa dividido en tres lóbulos, dado que su característica más sobresaliente " +
				"es el aspecto de tres lóbulos brillantes, separados por oscuras líneas de polvo.";
				
			
			MiniInfo.text="La nebulosa Trífida, que es una nebulosa tanto de emisión como de reflexión, y" +
				"de absorción al mismo tiempo, tiene un brillo aparente de +6.3 magnitudes. En el centro de la" +
				"nebulosa Trífida se encuentra el cúmulo abierto Collinder 360 (C1759-230), cuya estrella más" +
				"brillante es HD164492A, una estrella gigante azul de tipo espectral O.";
				
			
		
			break;
		
		
		
		
		}// fin switch info planeta
		
		
		
		
		
		
	}// Fin metodo
  
  
  
	public void Iniciacion ()
	{
		EsferaPlaneta.SetActive(true);
		InfoLuna1.SetActive(true);
		InfoLuna2.SetActive(true);
		InfoLuna3.SetActive(true);
		InfoLuna4.SetActive(true);
		Fobosa.SetActive(false);
		Deimos.SetActive(false);
		nix.SetActive(false);
		Sol.SetActive(false);
		Hydra.SetActive(false);
		
		FotoImagen.SetActive(false);

		
		Saturno.SetActive(false);
		
		EsferaLuna.SetActive(true);
		EsferaLuna2.SetActive(true);
		EsferaLuna3.SetActive(true);
		EsferaLuna4.SetActive(true);
		Luna.SetActive(false);
		
		
		
	}
  
  
  
  
}
