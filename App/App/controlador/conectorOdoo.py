import xml.etree.ElementTree as ET

def importConductorXMLaOdoo():
    archivo_xml = ET.parse('./bin/Debug/conductores.xml')
    raiz = archivo_xml.getroot()
    print(raiz)
    for subraiz in raiz:
        conductor = {
            'id_conductor':subraiz[0].text,
            'nombre':subraiz[1].text,
            'apellido':subraiz[2].text,
            'domicilio':subraiz[3].text,
            'permiso':subraiz[4].text,
            'disponibilidad':subraiz[5].text,
        }
        print(conductor)

def importVehiculoXMLaOdoo():
    archivo_xml = ET.parse('./bin/Debug/vehiculos.xml')
    raiz = archivo_xml.getroot()
    print(raiz)
    for subraiz in raiz:
        vehiculo = {
            'id_vehiculo':subraiz[0].text,
            'marca':subraiz[1].text,
            'tipoVehiculo':subraiz[2].text,
            'disponibilidadVehiculo':subraiz[3].text,
            'volumenGasolina':subraiz[4].text,
            'estado':subraiz[5].text,
        }
        print(vehiculo)

def importMercanciaXMLaOdoo():
    archivo_xml = ET.parse('./bin/Debug/mercancias.xml')
    raiz = archivo_xml.getroot()
    print(raiz)
    for subraiz in raiz:
        mercancia = {
            'id_producto':subraiz[0].text,
            'nombre':subraiz[1].text,
            'volumenProducto':subraiz[2].text,
        }
        print(mercancia)

def importRutasXMLaOdoo():
    archivo_xml = ET.parse('./bin/Debug/rutas.xml')
    raiz = archivo_xml.getroot()
    print(raiz)
    for subraiz in raiz:
        ruta = {
            'id_ruta':subraiz[0].text,
            'origen_ruta':subraiz[1].text,
            'destino_ruta':subraiz[2].text,
            'repostar_gasolina':subraiz[3].text,
            'duracion':subraiz[4].text,
            'precio_repostaje':subraiz[5].text,
            'kms_ruta':subraiz[6].text,
        }
        print(ruta)

# def importPedidosXMLaOdoo():
#    archivo_xml = ET.parse('./bin/Debug/pedidos.xml')
#   raiz = archivo_xml.getroot()
#   print(raiz)
#   for subraiz in raiz:
#       conductor = {
#           'id_conductor':subraiz[0].text,
#           'nombre':subraiz[1].text,
#           'apellido':subraiz[2].text,
#           'domicilio':subraiz[3].text,
#           'permiso':subraiz[4].text,
#           'disponibilidad':subraiz[5].text,
#       }
#       print(conductor)

importConductorXMLaOdoo()
importRutasXMLaOdoo()
importMercanciaXMLaOdoo()
importVehiculoXMLaOdoo()