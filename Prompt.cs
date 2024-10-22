# Recebe a Entrada do usuário e armazena na variável "entrada"
entrada = input()

# Função responsável por receber um recurso e retornar sua respectiva descrição.
def identificar_recurso_visao(recurso):
    if recurso == "Esclarecer dúvidas sobre imagens":
        return "Fornecer respostas a perguntas sobre o conteúdo da imagem"
    
    elif recurso == "Traduzir textos em imagens":
        return "Converter texto presente em imagens para outro idioma"
    
    elif recurso == "Extrair dados de imagens":
        return "Obter e estruturar dados visuais de imagens"
    
    elif recurso == "Identificar objetos em imagens":
        return "Analisar e identificar objetos específicos em imagens"
    
    # Caso o recurso não seja válido
    else:
        return "Recurso desconhecido"

# Chama a função e imprime a saída com base na entrada do usuário
print(identificar_recurso_visao(entrada))



# Recebe a Entrada do usuário e armazena na variável "entrada"
entrada = input()

# Função responsável por receber um recurso de texto e retornar sua respectiva descrição.
def identificar_recurso_texto(recurso):
    if recurso == "Sumarização":
        return "Sintetizar artigos extensos ou documentos em resumos breves"
    
    elif recurso == "Análise e interpretação de texto":
        return "Oferecer percepções e esclarecer conceitos complexos"
    
    elif recurso == "Geração de conteúdo":
        return "Desenvolver conteúdo com base em instruções ou diretrizes"
    
    elif recurso == "Redação e revisão":
        return "Auxiliar na criação de textos e revisão de materiais escritos"
    
    # Caso o recurso não seja válido
    else:
        return "Recurso desconhecido"

# Chama a função e imprime a saída com base na entrada do usuário
print(identificar_recurso_texto(entrada))



# Recebe a Entrada do usuário e armazena na variável "entrada"
entrada = input()

# Função responsável por receber uma prática e retornar sua respectiva descrição.
def identificar_pratica(pratica):
    if pratica == "Especificidade":
        return "Fornecer detalhes específicos para evitar ambiguidades"
    
    elif pratica == "Iteração":
        return "Ajustar o prompt com base no feedback recebido"
    
    elif pratica == "Clareza":
        return "Usar linguagem clara e direta"
    
    elif pratica == "Contextualização":
        return "Incluir contexto relevante para guiar a resposta"
    
    # Caso a prática não seja válida
    else:
        return "Prática desconhecida"

# Chama a função e imprime a saída com base na entrada do usuário
print(identificar_pratica(entrada))



# Recebe a Entrada do usuário e armazena na variável "entrada"
entrada = input()

# Função responsável por receber uma prática e retornar sua respectiva descrição.
def identificar_pratica(pratica):
    if pratica == "Especificidade":
        return "Fornecer detalhes específicos para evitar ambiguidades"
    
    # Descrição para Iteração
    elif pratica == "Iteração":
        return "Ajustar o prompt com base no feedback recebido"
    
    # Descrição para Clareza
    elif pratica == "Clareza":
        return "Usar linguagem clara e direta"
    
    # Descrição para Contextualização
    elif pratica == "Contextualização":
        return "Incluir contexto relevante para guiar a resposta"
    
    # Caso a prática não seja válida
    else:
        return "Prática desconhecida"

# Chama a função e imprime a saída com base na entrada do usuário
print(identificar_pratica(entrada))
